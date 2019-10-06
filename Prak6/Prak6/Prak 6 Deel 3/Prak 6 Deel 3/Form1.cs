using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prak_6_Deel_3
{
   
    public partial class Form1 : Form
    {
        String FirstName,
       LastName,
       emplID,
       TypeEmpl;
        double grossSal = 0,
            ratePay = 0,
            hours = 0;
        const double TAX_VAL = 0.18;
        const double RETIRE = 0.10;
        const double SOC_SEC = 0.06;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GetInfo(out FirstName, out LastName, out emplID);
            TypeEmpl = GetTypeOfEmployee();
            if (typeOfEmployee == "S") grossSal = double.Parse(txtWeek.Text);
            else
            {
                hours = double.Parse(txtHrs.Text);
                ratePay = double.Parse(txtHRSW.Text);
            }
            DisplayPayslip();
        }
        public void GetInfo(out string fn, out string ln, out string id)
        {
            fn = txtFN.Text;
            ln = txtLN.Text;
            id = txtID.Text;
        }
        public String GetTypeOfEmployee()
        {
            if (rbnSalaried.Checked) return "S";
            else return "H";
        }

    }
}
