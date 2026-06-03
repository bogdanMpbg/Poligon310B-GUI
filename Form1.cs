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
            double opseg;
            if (opsegX > opsegY) opseg = opsegY;
            else opseg = opsegX;

            PointF[] paneltacke = new PointF[p.br_temena];
            for (int i = 0; i < p.br_temena; i++)
            {
                paneltacke[i] = new PointF((float)((p.teme[i].x - xMin) * opseg), (float)(panelPoligon.Height - (p.teme[i].y - yMin) * opseg));
            }
            g.FillPolygon(boja, paneltacke);
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
            panelPoligon.Refresh();
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
                p = Poligon.ucitaj(dialog.FileName);
                upisi();
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
    }
}
