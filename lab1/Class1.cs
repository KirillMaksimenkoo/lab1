using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Quadrangle
    {
        double ab, bc, cd, ad, kyt1, kyt2;

        public Quadrangle(double ab, double bc, double cd, double ad, double kyt1, double kyt2)
        {
            this.ab = ab;
            this.bc = bc;
            this.cd = cd;
            this.ad = ad;
            this.kyt1 = kyt1; 
            this.kyt2 = kyt2;
        }

        public string Perevirka1()
        {
            if (ab == cd && bc == ad && ab != bc && ab != ad && cd != bc && cd != ad)
            {
                
                return "True";
            }
            else return "False";
        }

        public string Perevirka2()
        {
            double prkyt = kyt1 + kyt2;
            if (prkyt == 180)
            {
                
                return "True";
            }
            else return "False";
        }
    }
}
