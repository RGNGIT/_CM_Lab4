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
        }

        List<List<double>> Mtr = new List<List<double>>() 
        {
            new List<double>() { -1, 0.28f, -0.17f, 0.06f, -21 },
            new List<double>() { 0.52f, -1, 0.12f, 0.17f, 117 },
            new List<double>() { 0.17f, -0.18f, 0, -0.79f, 0.81 },
            new List<double>() { 0.11f, 0.22f, 0.03f, -0.95f, -0.72f}
        };

        private void buttonDoCalc_Click(object sender, EventArgs e)
        {
            double[] kek = new Zeidel(Mtr, 0.001).GetZeidelSolve;
        }
    }
}
