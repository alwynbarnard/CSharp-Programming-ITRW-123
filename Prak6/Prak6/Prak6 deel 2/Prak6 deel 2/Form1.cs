using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prak6_deel_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void GetWeightHeight(out double Lenght, out double Weight)
        {
            Lenght = double.Parse(textBox1.Text);
            Weight = double.Parse(textBox2.Text);
        }
        public String GetBMI(double Len, double Weig)
        {
            double Value = Weig / (Math.Pow(Len, 2));
            if (Value >= 30) return "Obese";
            if (Value >= 25) return "Overweight";
            if (Value >= 18.5)
            { return "Normal"; }
            else { return "Underweight"; }
        }
        public void DisplayBMI()
        {
            double Lengte, Gewig;
            GetWeightHeight(out Lengte, out Gewig);
            label3.Text = "Your BMI is: " + GetBMI(Lengte, Gewig);
        }
        private void btnBMI_Click(object sender, EventArgs e)
        {
            DisplayBMI();
        }
    }
}
