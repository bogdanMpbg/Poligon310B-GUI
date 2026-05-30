using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmpoligon
{
    class Vektor
    {
        public Tacka pocetak;
        public Tacka kraj;

        public Vektor(Tacka pocetak, Tacka kraj)
        {
            this.pocetak = pocetak;
            this.kraj = kraj;
        }

        public static double SP(Vektor a, Vektor b)
        {
            Tacka at = a.centriraj();
            Tacka bt = b.centriraj();
            return at.x * bt.x + at.y * bt.y;
        }

        public static double VP(Vektor a, Vektor b)
        {
            Tacka at = a.centriraj();
            Tacka bt = b.centriraj();
            return at.x * bt.y - at.x * bt.y;
        }

        public double duzina()
        {
            Tacka druga = this.centriraj();
            return druga.d();
        }

        public Tacka centriraj()
        {
            double x = kraj.x - pocetak.x;
            double y = kraj.y - pocetak.y;
            return new Tacka(x, y);
        }

        public bool sece(Vektor b)
        {
            int x = Ravan.SIS(this, b.pocetak, b.kraj);
            int y = Ravan.SIS(b, this.pocetak, this.kraj);
            if (x * y != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
