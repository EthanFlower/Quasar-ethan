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
         LOOK AT THE newMnyValue! IT CANNOT WORK WITH 15, 16, 18, 19 DUE TO DECIMALS! FIIIIIIIXXXXXXX!!!! 
         
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
        private int lastNum;
        private int totalMoney = 500;//starting amount of money
        private int lastRoll;
        private Boolean foldOrNext = true;
        //private Array Strings = new Array[]{"YouwentOver!", "Rolled:" }; trying to have preset strings. possibly doing in future update
        public Form1()
        {
            InitializeComponent();
        }

        private void rolled(int min, int max)
        {
            if (lastNum <= 20)
            {
                lastRoll = die.roll(min, max);
                lastNum += lastRoll;
                label1.Text = "" + lastNum;
                rollNum.Text = "Rolled:" + lastRoll;
            }
            if (lastNum > 20)
            {
                wentOver.Text = "You went over!";
                button3_Click(null, EventArgs.Empty);
            }
        }

        private void die18_Click(object sender, EventArgs e)
        {
            rolled(1, 8);
        }

        private void die47_Click(object sender, EventArgs e)
        {
            rolled(4, 7);
        }

        private double times(decimal inty, double douby)
        {
            double n = 0;
            for (int i = 0; i < (int)inty; i++)
            {
                n += douby;
            }
            return n;
        }

        private void getNewMnyValue()
        {
            //saving code
            int profitNum = 0;
            double profitPer = 0;
            if (lastNum > 20)
            {
                //getting ideas down
                profitNum += 0;
                profitPer += 0;
            }
            else
            {
                for (int i = 15; i < 16; i++)
                {
                    if (lastNum == i)
                    {
                        profitPer += (0.25 * (i - 14));
                        profitNum += (int)times(betUpDown.Value, profitPer);
                    }

                }
                for (int i = 17; i < 19; i++)
                {
                    if (lastNum == i)
                    {
                        profitPer += (1 + (0.25 * (i - 17)));
                        profitNum += (int)times(betUpDown.Value, profitPer);
                    }
                }
                if (lastNum == 20)
                {
                    profitPer += 2;
                    profitNum += (int)times(betUpDown.Value, profitPer);
                }
                //lastly...
                totalMoney += profitNum;
                mnyNum.Text = "" + totalMoney;
                profitLb.Text = "Profit: " + profitNum + ", " + profitPer*100 + "% Gain";
            }
        }

        private void newRound()
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
            die18.Enabled = false;
            die47.Enabled = false;
            button3.Enabled = false;//fold
            betUpDown.Enabled = true;
            betButt.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //have turn change when fold && give money back
            if (foldOrNext == true)
            {
                getNewMnyValue();
                die18.Enabled = false;
                die47.Enabled = false;
                button3.Text = "Next Round";
                foldOrNext = false;
            }//button is then used to start the new round
            else if (foldOrNext == false)
            {
                newRound();
                button3.Text = "Fold";
                foldOrNext = true;

            }
        }

        private void betButt_Click(object sender, EventArgs e)
        {
            die18.Enabled = true;
            die47.Enabled = true;
            button3.Enabled = true;//fold
            betUpDown.Enabled = false;
            betButt.Enabled = false;
            totalMoney -= (int)betUpDown.Value;
            mnyNum.Text = "" + totalMoney;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newRound();
        }


    }
}
