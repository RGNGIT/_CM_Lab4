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
            List<double> prevVal = new List<double>();
            for(int i = 0; i < Mtr.Count; i++)
            {
                prevVal.Add(0);
            }
            while(true)
            {
                List<double> currVal = new List<double>();
                for(int i = 0; i < Mtr.Count; i++)
                {
                    currVal.Add(0);
                }
                for(int i = 0; i < Mtr.Count; i++)
                {
                    currVal[i] = Mtr[i][Mtr.Count];
                    for(int j = 0; j < Mtr.Count; j++)
                    {
                        if(j < i)
                        {
                            currVal[i] -= Mtr[i][j] * currVal[j];
                        }
                        if(i > j)
                        {
                            currVal[i] -= Mtr[i][j] * prevVal[j];
                        } 
                    }
                    currVal[i] /= Mtr[i][i];
                }
                double Offset = 0;
                for(int i = 0; i < Mtr.Count; i++)
                {
                    Offset += Math.Abs(!Double.IsNaN(currVal[i] - prevVal[i]) ? Math.Abs(currVal[i] - prevVal[i]) : 0);
                }
                if(Offset < Eps)
                {
                    break;
                }
                prevVal = currVal;
            }
            return prevVal.ToArray();
        }
    }
}
