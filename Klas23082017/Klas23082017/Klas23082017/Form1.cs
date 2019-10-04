using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klas23082017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //1 waarde terug stuur: Gebruik return type
        //Meer waardes terug stuur : gebruik out type
        private void GetValues(out int wyd, out int hoog)
        {
            wyd = int.Parse(txtWidth.Text);
            hoog = int.Parse(txt.Text);
        }
        private int BerekenOmtrek(int wid,int heig)
        {
            return 2 * wid + 2 * heig;
        }
       private int BerekenOppv(int widt, int heigh)
        {
            return widt * heigh;
        }
       private void DisplayAnsw(int omt,int oppv)
        {
            label1.Text = "Die omtrek is: " + omt;
            label2.Text = " Die oppervlakte is: " + oppv;
       }
        private void btnVerwerking_Click(object sender, EventArgs e)
        {
            int w, h, Area,oppv;
            //As jy out gebruik moet jy dit by die roep van die method ook roep
            GetValues(out w, out h);
            Area = BerekenOmtrek(w, h);
            oppv = BerekenOppv(w, h);
            DisplayAnsw(Area,oppv);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
