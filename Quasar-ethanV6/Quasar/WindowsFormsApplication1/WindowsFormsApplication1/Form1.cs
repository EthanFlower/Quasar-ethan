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
        Fixed ---- LOOK AT THE newMnyValue! IT CANNOT WORK WITH 15, 16, 18, 19 DUE TO DECIMALS! FIIIIIIIXXXXXXX!!!! 
         
        Shortcut keys
        Ctrl K -> Ctrl D :Format whole document  

        Info
        do - while loop - do{this code}while(this is true);
       
        List of stuff to do or can do
        1.change the max bet amount to their points
        2.hide cheat buttons/numeric up downs that appear if screen is expanded?
        3.
        */


        private Die die = new Die();
        public int lastNum;
        public int totalMoney = 500;//starting amount of money
        public Boolean foldTOrNextF = true;
        //private Array Strings = new Array[]{"Youwentver!", "Rolled:" }; trying to have preset strings. possibly doing in future update
        public Form1()
        {
            InitializeComponent();
        }

        public void die18_Click(object sender, EventArgs e)
        {
            die.rolled(1, 8);
        }

        public void die47_Click(object sender, EventArgs e)
        {
            die.rolled(4, 7);
        }

        public void button3_Click(object sender, EventArgs e)
        {
            //have turn change when fold && give money back
            if (foldTOrNextF == true)
            {
                prepNextRound();
            }//button is then used to start the new round
            else if (foldTOrNextF == false)
            {
                nextRound();
            }
        }
        public void betButt_Click(object sender, EventArgs e)
        {
            setBet();
        }
    }
}
