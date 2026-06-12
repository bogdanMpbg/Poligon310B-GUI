using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;
using System.Drawing.Imaging;

namespace bmpoligon
{
    public partial class Form1 : Form
    {
        Poligon p;
        Graphics g;
        Brush boja;
        public Form1()
        {
            InitializeComponent();
        }

        private void upisi()
        {
            listBoxTacke.Items.Clear();
            for (int i = 0; i < p.br_temena; i++)
            {
                listBoxTacke.Items.Add($"({p.teme[i].x}, {p.teme[i].y})");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p = new Poligon(3);
            p.teme[0] = new Tacka(0, 0);
            p.teme[1] = new Tacka(5, 3);
            p.teme[2] = new Tacka(7, 0);
            g = panelPoligon.CreateGraphics();
            boja = Brushes.Red;

            panelPoligon.Refresh();
        }

        private void panelPoligon_Paint(object sender, PaintEventArgs e)
        {
            if (p.br_temena > 0)
            {
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, panelPoligon.Width, panelPoligon.Height));
                double xMax = p.teme[0].x;
                double xMin = p.teme[0].x;
                double yMax = p.teme[0].y;
                double yMin = p.teme[0].y;
                for (int i = 1; i < p.br_temena; i++)
                {
                    if (p.teme[i].x > xMax) xMax = p.teme[i].x;
                    if (p.teme[i].x < xMin) xMin = p.teme[i].x;
                    if (p.teme[i].y > yMax) yMax = p.teme[i].y;
                    if (p.teme[i].y < yMin) yMin = p.teme[i].y;
                }
                double opsegX = panelPoligon.Width / (xMax - xMin);
                double opsegY = panelPoligon.Height / (yMax - yMin);
                double centarX = 0;
                double centarY = 0;
                int brojLinija = 0;
                int pocetnaX = 0;
                int pocetnaY = 0;
                double opseg;
                if (opsegX > opsegY)
                {
                    opseg = opsegY;
                    centarX = ((yMax - yMin) - (xMax - xMin)) / 2;
                    brojLinija = (int)Math.Ceiling(yMax - yMin);
                    pocetnaX = (int)Math.Floor((xMax - xMin) - (yMax - yMin));
                }
                else
                {
                    opseg = opsegX;
                    centarY = ((xMax - xMin) - (yMax - yMin)) / 2;
                    brojLinija = (int)Math.Ceiling(xMax - xMin);
                    pocetnaY = (int)Math.Floor((yMax - yMin) - (xMax - xMin));
                }

                if (checkBoxMreza.Checked)
                {
                    for (int x = pocetnaX; x < brojLinija; x++)
                    {
                        PointF t1 = new PointF((float)((x - xMin + centarX) * opseg), 0);
                        PointF t2 = new PointF((float)((x - xMin + centarX) * opseg), panelPoligon.Height);
                        g.DrawLine(new Pen(Brushes.Black), t1, t2);
                    }
                    for (int y = pocetnaY; y < brojLinija; y++)
                    {
                        PointF t1 = new PointF(0, (float)(panelPoligon.Height - (y - yMin + centarY) * opseg));
                        PointF t2 = new PointF(panelPoligon.Width, (float)(panelPoligon.Height - (y - yMin + centarY) * opseg));
                        g.DrawLine(new Pen(Brushes.Black), t1, t2);
                    }
                }

                PointF[] paneltacke = new PointF[p.br_temena];
                for (int i = 0; i < p.br_temena; i++)
                {
                    paneltacke[i] = new PointF((float)((p.teme[i].x - xMin + centarX) * opseg), (float)(panelPoligon.Height - (p.teme[i].y - yMin + centarY) * opseg));
                }
                g.FillPolygon(boja, paneltacke);

                if (checkBoxIvice.Checked)
                {
                    for (int i = 0; i < p.br_temena; i++)
                    {
                        g.DrawLine(new Pen(Brushes.Black), paneltacke[i], paneltacke[(i+1) % p.br_temena]);
                    }
                }

                if (checkBoxTacke.Checked)
                {
                    for (int i = 0; i < p.br_temena; i++)
                    {
                        g.FillEllipse(Brushes.Black, paneltacke[i].X - 5, paneltacke[i].Y - 5, 10, 10);
                    }
                }

                
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBoxX.Text);
                double y = Convert.ToDouble(textBoxY.Text);
                listBoxTacke.Items.Add($"({textBoxX.Text}, {textBoxY.Text})");
                textBoxX.Text = "";
                textBoxY.Text = "";
            } catch (FormatException ex)
            {
                MessageBox.Show("Niste ispravno uneli koordinate.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            if (listBoxTacke.SelectedIndex != -1)
            {
                listBoxTacke.Items.RemoveAt(listBoxTacke.SelectedIndex);
                textBoxX.Text = "";
                textBoxY.Text = "";
            }
        }

        private void listBoxTacke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTacke.SelectedIndex != -1)
            {
                string tackastr = (string)listBoxTacke.Items[listBoxTacke.SelectedIndex];
                string xstr = tackastr.Split(',')[0].Substring(1);
                string ystr = tackastr.Split(',')[1].Trim();
                ystr = ystr.Substring(0, ystr.Length - 1);
                textBoxX.Text = xstr;
                textBoxY.Text = ystr;
            } else
            {
                //textBoxX.Text = "";
                //textBoxY.Text = "";
            }
        }

        private void buttonOcisti_Click(object sender, EventArgs e)
        {
            listBoxTacke.Items.Clear();
            textBoxX.Text = "";
            textBoxY.Text = "";
        }

        private void buttonNapravi_Click(object sender, EventArgs e)
        {
            p = new Poligon(listBoxTacke.Items.Count);
            for (int i = 0; i < listBoxTacke.Items.Count; i++)
            {
                string tackastr = (string)listBoxTacke.Items[i];
                string xstr = tackastr.Split(',')[0].Substring(1);
                string ystr = tackastr.Split(',')[1].Trim();
                ystr = ystr.Substring(0, ystr.Length - 1);
                p.teme[i] = new Tacka(Convert.ToDouble(xstr), Convert.ToDouble(ystr));
            }
            MessageBox.Show("Poligon uspesno napravljen.", "Poligon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonNacrtaj_Click(object sender, EventArgs e)
        {
            panelPoligon.Refresh();
        }

        private void buttonSnimi_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                p.snimi(dialog.FileName);
            }
        }

        private void buttonUcitaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    p = Poligon.ucitaj(dialog.FileName);
                    upisi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska pri ucitavanju poligona. Proverite da li je fajl ispravan.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                panelPoligon.Refresh();
            }
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBoxX.Text);
                double y = Convert.ToDouble(textBoxY.Text);
                int index = listBoxTacke.SelectedIndex;
                listBoxTacke.Items.RemoveAt(index);
                listBoxTacke.Items.Insert(index, $"({textBoxX.Text}, {textBoxY.Text})");
                textBoxX.Text = "";
                textBoxY.Text = "";
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Niste ispravno uneli koordinate.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonProst_Click(object sender, EventArgs e)
        {
            bool prost = p.prost();
            if (prost)
            {
                MessageBox.Show("Prost", "Poligon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nije prost", "Poligon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonKonveksan_Click(object sender, EventArgs e)
        {
            bool konveksan = p.konveksan();
            if (konveksan)
            {
                MessageBox.Show("Konveksan", "Poligon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Konkavan", "Poligon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonPovrsina_Click(object sender, EventArgs e)
        {
            try
            {
                double povrsina = p.povrsina();
                MessageBox.Show($"Povrsina je {povrsina}", "Poligon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Samo prosti poligoni imaju povrsinu.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBoja_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = ((SolidBrush)boja).Color;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                boja = new SolidBrush(dialog.Color);
                panelPoligon.Refresh();
            }
        }

        private void checkBoxIvice_CheckedChanged(object sender, EventArgs e)
        {
            panelPoligon.Refresh();
        }

        private void checkBoxTacke_CheckedChanged(object sender, EventArgs e)
        {
            panelPoligon.Refresh();
        }

        private void buttonSlika_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(panelPoligon.Width, panelPoligon.Height);
            g = Graphics.FromImage(bm);
            panelPoligon_Paint(null, null);
            g = panelPoligon.CreateGraphics();
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Bitmap Image (.bmp)|*.bmp|GIF Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|PNG Image (.png)|*.png|TIFF Image (.tiff)|*.tiff|WMF Image (.wmf)|*.wmf";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(dialog.FileName).ToLower();
                ImageFormat format = null;
                switch (ext)
                {
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                    case ".gif":
                        format = ImageFormat.Gif;
                        break;
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".jpeg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".tiff":
                        format = ImageFormat.Tiff;
                        break;
                    case ".wmf":
                        format = ImageFormat.Wmf;
                        break;
                }
                
                bm.Save(dialog.FileName, format);
            }
        }

        private void checkBoxMreza_CheckedChanged(object sender, EventArgs e)
        {
            panelPoligon.Refresh();
        }
    }
}
