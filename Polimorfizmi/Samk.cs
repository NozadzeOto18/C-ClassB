using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizmi
{
    class Samk
    {
        int simagle, fudze;
        int gverdi_1, gverdi_2, gverdi_3;
        double fart_samk;
        int perim_samk;


        public int Formula(int gverdi_1, int gverdi_2, int gverdi_3)
        {
            this.gverdi_1 = gverdi_1;
            this.gverdi_2 = gverdi_2;
            this.gverdi_3 = gverdi_3;

            this.perim_samk = this.gverdi_1 + this.gverdi_2 + this.gverdi_3;

            return this.perim_samk;
        }


        public double Formula(int fudze, int simagle)
        {
            this.fudze = fudze;
            this.simagle = simagle;
            this.fart_samk = this.fudze * this.simagle;
            return this.fart_samk;
        }
    }
}
