using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Assignment_LEGACY
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();


            ////////EXTRA STUFF (unnecessary and only for the fun of it) :)/////////
            unchecked
            {
                
                Random random = new Random();//create a Random object and call it random.

                //create integer called val, and assign a random value to it, between -21474838648(minimum integer) and 21474838647(maximum integer)
                int val =random.Next(int.MinValue,int.MaxValue);
                val |= (int)0xff000000;//this line is to keep ALPHA in ARGB* at full 255.
                BackColor = Color.FromArgb(val);
            }

            /*
             *ARGB in color uses 8 hexadecimal values, max value is #FF_FF_FF_FF
                first FF is alpha(aka opacity, aka the opposite of transparency).
                second FF is red
                third FF is green
                fourth FF is blue
            the entire 8 hexadecimal value is stored in a 32 bit integer, very convenient.
             */
            ///////END OF EXTRA STUFF//////////
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
