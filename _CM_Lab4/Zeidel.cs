using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CM_Lab4
{
    class Zeidel
    {
        List<List<double>> Mtr;
        double Eps;

        public Zeidel(List<List<double>> Mtr, double Eps)
        {
            this.Mtr = Mtr;
            this.Eps = Eps;
        }

        public double[] GetZeidelSolve
        {
            get
            {
                return DoZeidel();
            }
        }

        double[] DoZeidel()
        {
            return null;
        }
    }
}
