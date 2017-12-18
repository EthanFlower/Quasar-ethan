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
        Form2 form2;
        Form3 form3;
        //public static Form1 use = Form1(this);
        public int lastNum;
        public static int startingMoney = 500;
        public int roundNumber = 0;
        private int totalRounds = 5;
        public int totalMoney = startingMoney;//starting amount of money
        private int lastRoll;
        private Boolean foldOrNext = true;
        //private Array Strings = new Array[]{"YouwentOver!", "Rolled:" }; trying to have preset strings. possibly doing in future update
        public Form1()
        {
            InitializeComponent();
            form3 = new Form3(this);
        }
        public Form1(Form3 f) {
            form3 = f;
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

        private void canCashOut() {
            if (lastNum >= 15)
            {
                button3.Enabled = true;
            }
            else if (lastNum < 15)
            {
                button3.Enabled = false;
            }
        }

        private void die18_Click(object sender, EventArgs e)
        {
            rolled(1, 8);
            canCashOut(); 
        }

        private void die47_Click(object sender, EventArgs e)
        {
            rolled(4, 7);
            canCashOut();
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
                if (lastNum == 15)
                {
                    profitPer += 0.25;
                    profitNum += (int)((double)betUpDown.Value * profitPer);
                }

                if (lastNum == 16)
                {
                    profitPer += 0.5;
                    profitNum += (int)((double)betUpDown.Value * profitPer);
                }
                if (lastNum == 17)
                {
                    profitPer += 1;
                    profitNum += (int)((double)betUpDown.Value * profitPer);
                }
                if (lastNum == 18)
                {
                    profitPer += 1.25;
                    profitNum += (int)((double)betUpDown.Value * profitPer);
                }
                if (lastNum == 19)
                {
                    profitPer += 1.5;
                    profitNum += (int)((double)betUpDown.Value * profitPer);
                }
                if (lastNum == 20)
                {
                    profitPer += 2;
                    profitNum += (int)((double)betUpDown.Value * profitPer);
                }
                //lastly...
                totalMoney += profitNum;
                mnyNum.Text = "" + totalMoney;
                profitLb.Text = "Profit: " + profitNum + ", " + profitPer * 100 + "% Gain";
            }
        }

        public void newRound()
        {
            //allows for the customization of the game & used after each turn
            mnyNum.Text = "" + totalMoney;
            roundNumber += 1;
            lbRound.Text = "Round " + roundNumber;
            betUpDown.Maximum = totalMoney;//max bet amount
            betUpDown.Minimum = (int)(startingMoney * 0.22);//min bet amount made so you have to win to keep playing
            betUpDown.Value = betUpDown.Minimum;//set starting bet to minimum
            lastNum = die.roll(1, 3);
            label1.Text = "" + lastNum;
            rollNum.Text = "Rolled: Nothing Yet";
            wentOver.Text = "";
            profitLb.Text = "";
            die18.Enabled = false;
            die47.Enabled = false;
            button3.Enabled = false;//fold
            buttReset.Visible = false;
            betUpDown.Enabled = true;
            betButt.Enabled = true;
        }
        private void gameOver()
        {
            form3 = new Form3();
            die18.Enabled = false;
            die47.Enabled = false;
            button3.Enabled = false;//fold
            betUpDown.Enabled = false;
            betButt.Enabled = false;
            buttReset.Visible = true;
            profitLb.Text = "";
            //load a game over form?
            //form3.ShowDialog();
            
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
                if (roundNumber == totalRounds || totalMoney < betUpDown.Minimum)
                {
                    gameOver();
                }
                else
                {
                    newRound();
                    button3.Text = "Fold";
                    foldOrNext = true;
                }
            }
        }

        private void betButt_Click(object sender, EventArgs e)
        {
            die18.Enabled = true;
            die47.Enabled = true;
            button3.Enabled = false;//fold
            betUpDown.Enabled = false;
            betButt.Enabled = false;
            totalMoney -= (int)betUpDown.Value;
            mnyNum.Text = "" + totalMoney;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            roundNumber = 0;
            newRound();
        }

        private void buttInstruct_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.ShowDialog();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i += 0) {
                new Form4();//form bomb! DO NOT PRESS! Acts like a zip bomb in theory...
            }
        }

        private void buttReset_Click(object sender, EventArgs e)
        {
            totalMoney = startingMoney;
            roundNumber = 0;
            newRound();
        }
    }
}
