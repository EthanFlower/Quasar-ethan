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
        private int totalMoney = 500;//starting amount of money
        private int lastRoll;
        //private Array Strings = new Array[]{"YouwentOver!", "Rolled:" }; trying to have preset strings
        public Form1()
        {
            InitializeComponent();
        }

        private void die18_Click(object sender, EventArgs e)
        {
            if (lastNum <= 20)
            {
                lastRoll = die.roll(1, 8);
                lastNum += lastRoll;
                label1.Text = "" + lastNum;
                rollNum.Text = "Rolled:" + lastRoll;
            }
            if (lastNum > 20) { wentOver.Text = "You went over!"; }
        }

        private void die47_Click(object sender, EventArgs e)
        {
            if (lastNum <= 20)
            {
                lastRoll = die.roll(4, 7);
                lastNum += lastRoll;
                label1.Text = "" + lastNum;
                rollNum.Text = "Rolled:" + lastRoll;
            }
            if (lastNum > 20) { wentOver.Text = "You went over!"; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //have turn change when fold
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //allows for the customization of the game & used after each turn
            mnyNum.Text = "" + totalMoney;
            betUpDown.Maximum = totalMoney;//max bet amount
            betUpDown.Minimum = (totalMoney / 50) * 11;//min bet amount made so you have to win to keep playing
            betUpDown.Value = betUpDown.Minimum;//set starting bet to minimum
            lastNum = die.roll(1, 4);
            label1.Text = "" + lastNum;
            rollNum.Text = "Rolled: Nothing Yet";
            wentOver.Text = "";
        }


    }
}
