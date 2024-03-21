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
        private int perim_kvad, perim_mart, perim_samk;
        private int fart_kvad, fart_mart;
        private double fart_samk, sigrdze_wris, fart_wris;

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
            perim_mart = 2 * (this.gverdi_1 + this.gverdi_2);
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
        public int Perim_Kvad()
        {
            return perim_kvad;
        }
        public int Perim_Mart()
        {
            return perim_mart;
        }
        public int Perim_Samk()
        {
            return perim_samk;
        }
        public double Sigrdze_Wris()
        {
            return sigrdze_wris;
        }

        public int Fart_Kvad()
        {
            return fart_kvad;
        }
        public int Fart_Mart()
        {
            return fart_mart;
        }
        public double Fart_Samk()
        {
            return fart_samk;
        }
        public double Fart_Wris()
        {
            return fart_wris;
        }
    }
}
