using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    //Namespaces bestaan uit classes en classes bestaan uit methods
    public partial class Form1 : Form  //Object van die class form1 
    {
        Graphics papier;
        BalKlas bal1;
        BalKlas bal2 = new BalKlas(20);
        BalKlas bal3 = new BalKlas(30,50);
        public Form1() //Constructer
        {
            InitializeComponent();
            bal1 = new BalKlas();
            bal1.XCoord = 30;  //Bal begin nou nie by 0 nie maar by 30
            papier = pictureBox1.CreateGraphics();
            bal2.YCoord = 20;
            bal3.YCoord = 20;
            bal3.XCoord = 0;
        }
        private void btnClass_Click(object sender, EventArgs e)
        {
            bal1.Move(20);
            papier.Clear(Color.SaddleBrown);
            bal1.DrawBall(papier);
        }
        private void btnOverload_Click(object sender, EventArgs e)
        {
            bal2.Move(50);
            papier.Clear(Color.Gainsboro);
            bal2.DrawBall1(papier);
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            bal3.Move(42);
            papier.Clear(Color.PapayaWhip);
            bal3.DrawBall2(papier);
        }
    }
}
