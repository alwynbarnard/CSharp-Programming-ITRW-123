using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap10
{
    public partial class Form1 : Form
    {
        //Global variables
        double totaal = 0.0;
        string paymentMethod = "N/A";
        string cashierName = "N/A";
        string resultSlip = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text += listBox1.Text; //As jy se .text dan vat hy ListBox se geselekteerde items
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Ook close
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ek kan GUI skep. YASSSSSSSSS");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cashierName = comboBox1.Text;
        }

        private void PayMethod_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                paymentMethod = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                paymentMethod = radioButton2.Text;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cashier: " + cashierName + "\nPayment Method: " + paymentMethod + "\nResult : " +resultSlip + totaal);
        }

        private void Cost_CheckedChanged(object sender, EventArgs e)
        {
            double cost = 0.0;
            if (checkBox1.Checked)
            {
                cost = 10.0;
            }
            if (checkBox2.Checked)
            {
                cost = 15.0;
            }
            if (checkBox3.Checked)
            {
                cost = 23.5;
            }
            resultSlip += "R " + cost;
            totaal += cost;
        }
    }
}
