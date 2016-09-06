using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Statistics
    {
        public Random rnd;
        public Statistics()
        {
            rnd = new Random();
        }

        public double Poisson(double media)//(double lambda) 
        {
            var r = rnd;
            double u = 0.0;

            u = ((double)r.Next(1000000)) / 1000000.0;


            u = (-1.0 * Math.Log(1.0 - u)) * media; /// lambda;
            /*

            u = ((double)r.Next(1000000)) / 1000000.0;

            u = 2.0 * media * u;
            */
            return u;
        }
    }
}
