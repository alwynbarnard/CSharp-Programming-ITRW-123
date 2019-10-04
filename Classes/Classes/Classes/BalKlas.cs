using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // Bygesit sodat ons die Graphics property wil gebruik

namespace Classes
{
    class BalKlas
    {
        //Instance variable so hy is tot al die methods se beskikking
        private int x = 0;
        private int r = 50;
        private int y= 30;

        public BalKlas() //Constructor
        {
            

        }
        public BalKlas(int rad) //Overloaded Constructor
        {
            r = rad;
        }
        public BalKlas(int rad, int yco) //Overloaded Constructor 2
        {
            r = rad;
            y = yco;
        }
        public int XCoord
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int YCoord
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public void Move(int xchange) //Method
        {
            //Ontvang x koordinaat en verander aan hom
            x = x + xchange;
        }

        public void DrawBall(Graphics papier) //Method
        {
            SolidBrush kwas = new SolidBrush(Color.CornflowerBlue);
            papier.FillEllipse(kwas, x, 0, r * 2, r * 2);
        }
        public void DrawBall1(Graphics papier) //Method
        {
            SolidBrush kwas1 = new SolidBrush(Color.PaleGoldenrod);
            papier.FillEllipse(kwas1, x, 0, r * 2, r * 2);
        }
        public void DrawBall2(Graphics papier) //Method
        {
            SolidBrush kwas2 = new SolidBrush(Color.CadetBlue);
            papier.FillEllipse(kwas2, x, 30, r * 2, r * 2);
        }
    }
}
