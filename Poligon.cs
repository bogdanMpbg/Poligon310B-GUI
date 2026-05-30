using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmpoligon
{
    class Poligon
    {
        public int br_temena;
        public Tacka[] teme;

        public Poligon(int n)
        {
            br_temena = n;
            teme = new Tacka[n];
        }

        public static Poligon unos()
        {
            Console.Write("Unesite broj temena: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Poligon rez = new Poligon(n);
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Teme({i + 1}).x = ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Teme({i + 1}).y = ");
                double y = Convert.ToDouble(Console.ReadLine());
                rez.teme[i] = new Tacka(x, y);
            }
            return rez;
        }

        public void stampa()
        {
            Console.WriteLine($"Poligon sa {br_temena} tacaka");
            for (int i = 0; i < br_temena; i++)
            {
                Console.WriteLine($"x={teme[i].x}, y={teme[i].y}");
            }
        }

        public static Poligon ucitaj()
        {
            StreamReader ulaz = new StreamReader("poligon.txt");
            int n = Convert.ToInt32(ulaz.ReadLine());
            Poligon rez = new Poligon(n);
            for (int i = 0; i < n; i++)
            {
                double x = Convert.ToDouble(ulaz.ReadLine());
                double y = Convert.ToDouble(ulaz.ReadLine());
                rez.teme[i] = new Tacka(x, y);
            }
            ulaz.Close();
            return rez;
        }

        public void snimi()
        {
            StreamWriter izlaz = new StreamWriter("poligon.txt");
            izlaz.WriteLine($"{br_temena}");
            for (int i = 0; i < br_temena; i++)
            {
                izlaz.WriteLine($"{teme[i].x}");
                izlaz.WriteLine($"{teme[i].y}");
            }
            izlaz.Close();
        }

        public double obim()
        {
            double o = 0;
            for (int i = 0; i < br_temena - 1; i++)
            {
                Vektor v1 = new Vektor(teme[i], teme[i + 1]);
                o += v1.duzina();
            }
            Vektor v2 = new Vektor(teme[br_temena - 1], teme[0]);
            o += v2.duzina();
            return o;
        }

        public bool konveksan()
        {
            int t = 0;
            for (int i = 0; i < br_temena; i++)
            {
                Vektor v1 = new Vektor(teme[i], teme[(i + 1) % br_temena]);
                Vektor v2 = new Vektor(teme[(i + 1) % br_temena], teme[(i + 2) % br_temena]);
                if (Vektor.VP(v1, v2) < 0)
                {
                    t++;
                }
            }
            if (t == 0 || t == br_temena)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool prost()
        {
            for (int i = 0; i < br_temena - 1; i++)
            {
                for (int j = i + 1; j < br_temena; j++)
                {
                    if (Tacka.iste(teme[i], teme[j]))
                    {
                        return false;
                    }
                }
            }

            Vektor[] stranica = new Vektor[br_temena];
            // napravim stranice
            for (int i = 0; i < br_temena; i++)
            {
                stranica[i] = new Vektor(teme[i], teme[(i + 1) % br_temena]);
            }

            for (int i = 0; i < br_temena - 2; i++)
            {
                int kraj = br_temena;
                if (i == 0)
                {
                    kraj--;
                }
                for (int j = i + 2; j < kraj; j++)
                {
                    if (stranica[i].sece(stranica[j]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public double povrsina()
        {
            if (prost())
            {
                throw new Exception("prosti poligoni nemaju povrsinu");
            }
            double[] x = new double[br_temena];
            double[] y = new double[br_temena];
            double rez = 0;
            for (int i = 0; i < br_temena; i++)
            {
                rez += teme[i].x * teme[(i + 1) % br_temena].y;
                rez -= teme[i].y * teme[(i + 1) % br_temena].x;
            }
            return Math.Abs(rez) / 2;
        }

        public bool kvadrat()
        {
            Vektor[] stranica = new Vektor[br_temena];
            // napravim stranice
            for (int i = 0; i < br_temena; i++)
            {
                stranica[i] = new Vektor(teme[i], teme[(i + 1) % br_temena]);
            }

            if ((stranica[0].duzina() == stranica[1].duzina()) &&
                (stranica[1].duzina() == stranica[2].duzina()) &&
                (stranica[2].duzina() == stranica[3].duzina()) &&
                (stranica[3].duzina() == stranica[0].duzina()) &&
                (Vektor.VP(stranica[0], stranica[1]) == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool pravougaonik()
        {
            Vektor[] stranica = new Vektor[br_temena];
            // napravim stranice
            for (int i = 0; i < br_temena; i++)
            {
                stranica[i] = new Vektor(teme[i], teme[(i + 1) % br_temena]);
            }

            if ((stranica[0].duzina() == stranica[2].duzina()) &&
                (stranica[1].duzina() == stranica[3].duzina()) &&
                (Vektor.VP(stranica[0], stranica[1]) == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deltoid()
        {
            Vektor[] stranica = new Vektor[br_temena];
            // napravim stranice
            for (int i = 0; i < br_temena; i++)
            {
                stranica[i] = new Vektor(teme[i], teme[(i + 1) % br_temena]);
            }

            if (
                (stranica[0].duzina() == stranica[3].duzina() && stranica[1].duzina() == stranica[2].duzina()) ||
                (stranica[0].duzina() == stranica[1].duzina() && stranica[2].duzina() == stranica[3].duzina())
                )
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
