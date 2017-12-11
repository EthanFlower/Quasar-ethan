using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        /*
        Shortcut keys
        Ctrl K -> Ctrl D :Format whole document  
          
       
        List of stuff to do or can do
        1.change the max bet amount to their points
        2.hide cheat buttons/numeric up downs that appear if screen is expanded?
             
        */


        private Die die = new Die();
        private int lastNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void die18_Click(object sender, EventArgs e)
        {
            if (lastNum <= 20)
            {
                lastNum += die.roll(1, 8);
                label1.Text = "" + lastNum;
            }
        }

        private void die47_Click(object sender, EventArgs e)
        {
            if (lastNum <= 20)
            {

                lastNum += die.roll(4, 7);
                label1.Text = "" + lastNum;
            }
        }
    }
}
