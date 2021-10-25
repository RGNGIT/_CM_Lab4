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
        App app;

        public Zeidel(App app, List<List<double>> Mtr, List<double> Equal, double Eps)
        {
            this.Mtr = Mtr;
            this.Equal = Equal;
            this.Eps = Eps;
            this.app = app;
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
            for (int i = 0; i < Mtr.Count; i++)
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
            double Res0 = Equal[i] / Mtr[i][i];
            double Res1 = 0;
            for(int j = 0; j < i; j++)
            {
                Res1 += (Mtr[i][j] / Mtr[i][i]) * currentRes[j];
            }
            double Res2 = 0;
            for(int j = i + 1; j < Mtr.Count; j++)
            {
                Res2 += (Mtr[i][j] / Mtr[i][i]) * previousRes[j];
            }
            return Res0 - Res1 - Res2;
        }

        List<double> ListCloner(List<double> ToClone)
        {
            List<double> Clone = new List<double>();
            foreach(var i in ToClone)
            {
                Clone.Add(i);
            }
            return Clone;
        }

        double[] DoZeidel()
        {
            List<double> currentRes = ListCloner(Equal);
            List<double> previousRes;
            int k = 0;
            do
            {
                previousRes = ListCloner(currentRes);
                for (int i = 0; i < Mtr.Count; i++)
                {
                    currentRes[i] = ClownFormula(i, currentRes, previousRes);
                }
                k++;
            }
            while (FindMaxAbs(currentRes, previousRes) > Eps);
            app.chart.Series.Add($"Точность {Eps}").Points.AddXY(Eps, k);
            return currentRes.ToArray();
        }
    }
}
