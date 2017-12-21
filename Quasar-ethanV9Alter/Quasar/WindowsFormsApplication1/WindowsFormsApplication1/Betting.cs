using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    class Betting
    {
        
        public Betting(Form1 f)
        {
            form1 = f;
        }
        //*
        public Betting(Turn t)
        {
            turn = t;
        }
        
        public Betting(Die d)
        {
            die = d;
        }
        
        public Betting(Betting b)
        {
            betting = b;
        }//*/
        private Betting betting;
        private Form1 form1;
        private Die die;
        private Turn turn;
        private double betUpDownVal;
        private int lastNumb;
        public int totalMoney = 500;//starting amount of money//here or where?
        //private Die die = new Die();
        public void setBet() {
            die = new Die(form1);
            form1.die18.Enabled = true;
            form1.die47.Enabled = true;
            form1.button3.Enabled = true;//fold
            form1.betUpDown.Enabled = false;
            form1.betButt.Enabled = false;
            totalMoney -= (int)form1.betUpDown.Value;
            form1.mnyNum.Text = "" + totalMoney;
        }

        public void getNewMnyValue()
        {
            die = new Die(form1);
            betUpDownVal = (double)form1.betUpDown.Value;
            lastNumb = die.lastNum;
            //saving code
            int profitNum = 0;
            double profitPer = 0;
            if (lastNumb > 20 || lastNumb < 15)
            {
                //getting ideas down
                profitNum += 0;
                profitPer += 0;
            }
            else
            {

                if (lastNumb== 15)
                {
                    profitPer += 0.25;
                    profitNum += (int)(betUpDownVal * profitPer);
                }

                if (lastNumb== 16)
                {
                    profitPer += 0.5;
                    profitNum += (int)(betUpDownVal * profitPer);
                }
                if (lastNumb== 17)
                {
                    profitPer += 1;
                    profitNum += (int)(betUpDownVal * profitPer);
                }
                if (lastNumb== 18)
                {
                    profitPer += 1.25;
                    profitNum += (int)(betUpDownVal * profitPer);
                }
                if (lastNumb== 19)
                {
                    profitPer += 1.5;
                    profitNum += (int)(betUpDownVal * profitPer);
                }
                if (lastNumb== 20)
                {
                    profitPer += 2;
                    profitNum += (int)(betUpDownVal * profitPer);
                }
                //lastly...
                totalMoney += profitNum;
                form1.mnyNum.Text = "" + totalMoney;
                form1.profitLb.Text = "Profit: " + profitNum + ", " + profitPer * 100 + "% Of Bet";
            }
        }
        
    }
}
