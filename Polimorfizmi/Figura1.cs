using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizmi
{
    class Figura_1
    {

        public int gverdi_1, gverdi_2, gverdi_3;
        public double radiusi;
        public int perim_kvad, perim_mart, perim_samk;
        private double sigrdze_wris, fart_samk, fart_wris;
        private int fart_kvad, fart_mart;
        public Figura_1(int gverdi_1)
        {
            this.gverdi_1 = gverdi_1;
            perim_kvad = 4 * this.gverdi_1;
            fart_kvad = this.gverdi_1 * this.gverdi_1;
        }

        public Figura_1(int gverdi_1, int gverdi_2)
        {
            this.gverdi_1 = gverdi_1;
            this.gverdi_2 = gverdi_2;
            perim_mart = (this.gverdi_1 + this.gverdi_2) * 2;
            fart_mart = this.gverdi_1 * this.gverdi_2;
        }

        public Figura_1(int gverdi_1, int gverdi_2, int gverdi_3)
        {
            this.gverdi_1 = gverdi_1;
            this.gverdi_2 = gverdi_2;
            this.gverdi_3 = gverdi_3;
            perim_samk = this.gverdi_1 + this.gverdi_2 + this.gverdi_3;
            fart_samk = this.gverdi_1 * this.gverdi_3 / 2.0;
        }

        public Figura_1(double radiusi)
        {
            this.radiusi = radiusi;
            sigrdze_wris = 2 * Math.PI * this.radiusi;
            fart_wris = Math.PI * Math.Pow(this.radiusi, 2);
        }

        public int Perim_kvad()
        {
            return perim_kvad;
        }

        public int Perim_samk()
        {
            return perim_samk;
        }

        public int Perim_mart()
        {
            return perim_mart;
        }

        public double Fart_samk()
        {
            return fart_samk;
        }
        public int Fart_mart()
        {
            return fart_mart;
        }

        public int Fart_kvad()
        {
            return fart_kvad;
        }

        public double Sigrdze_wris()
        {
            return sigrdze_wris;
        }
        public double Fart_wris()
        {
            return fart_wris;
        }
    }
}
