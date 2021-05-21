using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_10
{
    class Dice
    {
        protected double[] ps;
        double alpha;

        Random rnd = new Random();

        public Dice()
        {
            ps = new double[6] { 1 / 6f, 1 / 6f, 1 / 6f, 1 / 6f, 1 / 6f, 1 / 6f };
        }

        public int Roll()
        {
            int points = 1;
            alpha = rnd.NextDouble();          

            for(int i=0;i<this.ps.Length;i++)
            {
                if (alpha > 0)
                {
                    alpha -= this.ps[i];
                    if (alpha <= 0)
                    {
                        points = i+1;
                        break;
                    }

                }
                else
                {
                    points = i+1;
                    break;
                }
            }
            return points;
        }
    }
}
