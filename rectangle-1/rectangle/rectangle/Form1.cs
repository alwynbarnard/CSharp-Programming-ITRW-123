using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
    /* Hierdie program is 'n cool manier om 'n reghoek te teken. Yeeaaaahhhhhhh!!!!*/
    //Bo: Multiline comment
    //Hierdie: Single line comment
    //Raak gewoond daaraan om jou naam bo aan 'n program te sit. Dosent vereiste
namespace rectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    /*Spanner = Properties (Eienskappe, soos colour ens.)
                    Persboks = methods (Voer 'n taak uit)
                    Methods het altyd parameters. Dus sal na elke method hakkies kom en 
                    jy moet vir dit parameters gee */
            Graphics papier = pbxShape.CreateGraphics();
                    /* Papier is 'n method wat ons nounet geskep het. Kyk hoe is hy declare */
            SolidBrush gryskwas = new SolidBrush(Color.DarkGray);
            //Declare eers solidbrush se method as new en gee vir hom 'n method om uit te voer
            //nl Maak die ding grys
            //Draw = buitelyn
            //Fill = kleur in
            int val1, val2;
            //val1 = int.Parse(Convert.ToInt64(txtLength.text));
            //val2 = int.Parse(Convert.ToInt64(txtWidth.text));

            papier.FillRectangle(gryskwas,val1,val1,val2,val2); //Brush of Ander tipe rectangle of brush en koordinate

        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
