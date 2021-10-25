using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _CM_Lab4
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            chart.Series.Clear();
            chart.Titles.Add("Скорость сходимости");
        }

        List<List<double>> Mtr = new List<List<double>>()
        {
            new List<double>() { -1, 0.28f, -0.17f, 0.06f },
            new List<double>() { 0.52f, -1, 0.12f, 0.17f },
            new List<double>() { 0.17f, -0.18f, 1, -0.79f },
            new List<double>() { 0.11f, 0.22f, 0.03f, -0.95f }
        };
        List<double> Equal = new List<double>()
        {
            -21, 117, 0.81f, -0.72f
        };

        List<double> Epsilon = new List<double>()
        {
            0.01,
            0.001,
            0.0001,
            0.00001,
            0.000001
        };

        private void buttonDoCalc_Click(object sender, EventArgs e)
        {
            labelOutput.Text = string.Empty;
            foreach(var i in Epsilon)
            {
                double[] Res = new Zeidel(this, Mtr, Equal, i).GetZeidelSolve;
                labelOutput.Text += $"Корни при точности {i}\n";
                foreach (var j in Res)
                {
                    labelOutput.Text += j.ToString() + '\n';
                }
            }
            buttonDoCalc.Visible = false;
        }
    }
}
