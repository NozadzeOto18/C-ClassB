using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizmi
{
    class Figura
    {
        public int gverdi_1, gverdi_2, gverdi_3;
        public double radiusi;
        private int perim_kvad, perim_mart, perim_samk;
        private double sigrdze_wris;

        public int Perimetri(int gverdi_1)
        {
            this.gverdi_1 = gverdi_1;
            perim_kvad = 4 * this.gverdi_1;
            return perim_kvad;
        }
        public int Perimetri(int gverdi_1, int gverdi_2)
        {
            this.gverdi_1 = gverdi_1;
            this.gverdi_2 = gverdi_2;
            perim_mart = 2 * (this.gverdi_1 + this.gverdi_2);
            return perim_mart;
        }
        public int Perimetri(int gverdi_1, int gverdi_2, int gverdi_3)
        {
            this.gverdi_1 = gverdi_1;
            this.gverdi_2 = gverdi_2;
            this.gverdi_3 = gverdi_3;
            perim_samk = this.gverdi_1 + this.gverdi_2 + this.gverdi_3;
            return perim_samk;
        }
        public double Perimetri(double radiusi)
        {
            this.radiusi = radiusi;
            sigrdze_wris = 2 * Math.PI * this.radiusi;
            return sigrdze_wris;
        }
    }
}
