using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmpoligon
{
    class Tacka
    {
        public double x;
        public double y;
        public double d()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public Tacka(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static bool iste(Tacka A, Tacka B)
        {
            if (A.x == B.x && A.y == B.y)
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
