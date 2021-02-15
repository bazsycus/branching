using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Elagazsok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iBeolvas = int.Parse(textBox1.Text);
            /*  egyenlő ==
             *  nem egyenlő   !=
             *  <,>,<=,>=
             * */
            
            if (iBeolvas%2==0) //szám%szám2, a szám a szám2-vel képzett maradéka
            {
                //igaz ág
                label1.Text = "Páros";
            }
            else
            {
                //hamis ág
                label1.Text = "Páratlan";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iPontszam = int.Parse(textBox1.Text);
            if (iPontszam<40)
            {
                label1.Text = "Elégtelen";
            }
            else if (iPontszam<55)
            {
                label1.Text = "Görbül";
            }
            else if (iPontszam<70)
            {
                label1.Text = "Közepes";
            }
            else if (iPontszam<85)
            {
                label1.Text = "Jó";
            } else
            {
                label1.Text = "Stréber";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int iJegy = int.Parse(textBox1.Text);
            switch (iJegy)
            {
                case 1:
                    label1.Text = "Elégtelen";
                    break;
                case 2:
                    label1.Text = "Elégséges";
                    break;
                case 3:
                    label1.Text = "Közepes";
                    break;
                case 4:
                    label1.Text = "Jó";
                    break;
                case 5:
                    label1.Text = "Jeles";
                    break;
                default:
                    label1.Text = "Szabálytalan jegy";
                    break;
            }
        }
        /*A feltétel (igaz/hamis)
         * B feltétel (igaz/hamis)
         * A és B --> A igaz és B igaz akkor A és B igaz
         * és--> && altgr + c
         * A vagy B ..> AKKOr lesz igaz ha legalább az egyik igaz
         * vagy --> || alt gr + W
         * 
         * A && B megnézi hogy A igaz ha igaz megnézi hogy B igaz -->eredményt ad
         * Ha A hamis B-t már nem nézi meg
         * A & B  megnézi, hogy A igaz és megnézi hogy B igaz független A-tól
         */
        private void button4_Click(object sender, EventArgs e)
        {
            int iKor = int.Parse(textBox2.Text);
            int iSzol = int.Parse(textBox3.Text);
            //radioButton1.Checked-->bool logikai változó
            //ha be van jelölve akkor igaz különben hamis
            bool bNő = radioButton2.Checked;
            /*if (radioButton2.Checked) // ==true
            {//if (!radioButton1.Checked){ == false
                bNő = true;
            } else
            {
                bNő = false;
            }*/

            if ( (iKor>=65) || ((bNő) && (iSzol>=40))   )
            {
                label1.Text = "Nyugdíjas";
            }
            else
            {
                label1.Text = "Nem nyugdíjas";
            }
        }
    }
}
