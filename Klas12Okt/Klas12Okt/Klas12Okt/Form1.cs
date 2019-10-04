using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klas12Okt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //While lus om loop control te doen
            int counter = 1;
            while (counter < 6)
            {
                listBox1.Items.Add("Nr. " + counter);
                counter++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                listBox1.Items.Add("nr. " + i);
            }
        }
    }
}
