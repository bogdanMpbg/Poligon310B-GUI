using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            p = new Poligon(5);
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
    }
}
