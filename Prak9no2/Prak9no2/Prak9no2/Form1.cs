using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prak9no2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            randomValue = GenerateRandonNumber(num1);
            smallest = TestForSmallestValue(randomValue, smallest);
            largest = TestForLargestValue(randomValue, largest);
            IsItAnOddNumber(randomValue, ref numberOfOddValuesGenerated);
        }
    }
}
