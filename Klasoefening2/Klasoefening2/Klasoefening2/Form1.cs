using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klasoefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeken_Click(object sender, EventArgs e)
        {
            //Vierkant teken
             Graphics papier = picTeken.CreateGraphics();
             SolidBrush kwas = new SolidBrush(Color.Aquamarine);
             papier.FillRectangle(kwas, 20 , 81, 100, 80);
            

            //Driehoek teken
            //Comment vierkant uit omdat hulle oor mekaar sou teken
            Pen tekenPen = new Pen(Color.CadetBlue,5);
            papier.DrawLine(tekenPen,20,80,70,10);
            papier.DrawLine(tekenPen, 70, 10, 120, 80);
            papier.DrawLine(tekenPen, 20, 80, 120, 80);

        }
    }
}
