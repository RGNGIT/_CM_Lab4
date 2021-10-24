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
        List<double> Equal;
        double Eps;

        public Zeidel(List<List<double>> Mtr, List<double> Equal, double Eps)
        {
            this.Mtr = Mtr;
            this.Equal = Equal;
            this.Eps = Eps;
        }

        public double[] GetZeidelSolve
        {
            get
            {
                return DoZeidel();
            }
        }

        double FindMaxAbs(List<double> currentRes, List<double> previousRes)
        {
            double max = 0;
            for (int i = 0; i < currentRes.Count; i++)
            {
                if (Math.Abs(currentRes[i] - previousRes[i]) > max)
                {
                    max = Math.Abs(currentRes[i] - previousRes[i]);
                }
            }
            return max;
        }

        double ClownFormula(int i, List<double> currentRes, List<double> previousRes)
        {
            return 0;
        }

        double[] DoZeidel()
        {
            List<double> currentRes = Equal;
            List<double> previousRes = Equal;
            do
            {
                for (int i = 0; i < Mtr.Count; i++)
                {
                    currentRes[i] = ClownFormula(i, currentRes, previousRes);
                }
                previousRes = currentRes;
            }
            while (FindMaxAbs(currentRes, previousRes) <= Eps);
            return previousRes.ToArray();
        }
    }
}
