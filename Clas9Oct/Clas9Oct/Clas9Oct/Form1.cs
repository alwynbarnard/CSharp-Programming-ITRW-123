using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clas9Oct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Squareroot()
        {
            int counter = 0;
            int top = int.Parse(textBox1.Text);
            string result = "\t n" + "\tSquared\n";
            while (counter < top)
            {
                counter++;
                result = result + "\t" + counter + "\t" + Math.Pow(counter, 2) + "\n";
   
            }
            MessageBox.Show(result, "1-" + top + " and their ");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int top = int.Parse(textBox1.Text);
            int number = 1;
            //Counter controlled loop
            while (number <= top)
            {
                sum = sum + number;
                // number++;   Causes an infinite loop
                number++;
            }

            lbl1.Text = "Sum of 1 to " + top + " is" + sum;

            Squareroot();

        }
    }
}
