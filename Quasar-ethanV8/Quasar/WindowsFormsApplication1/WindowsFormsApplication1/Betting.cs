using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{

    class Betting
    {
        private Form1 form1;


        public Betting(Form1 f)
        {
            form1 = f;
        }


        private Die die = new Die();
        private double betUpDownVal;
        private int lastNum;
        public int totalMoney = 500;//starting amount of money//here or where?
        //private Die die = new Die();
        public void setBet() {
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
            betUpDownVal = (double)form1.betUpDown.Value;
            lastNum = die.lastNum;
            //saving code
            int profitNum = 0;
            double profitPer = 0;
            if (lastNum > 20 || lastNum < 15)
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
                    profitNum += (int)(betUpDownVal * profitPer);
                }

                if (lastNum == 16)
                {
                    profitPer += 0.5;
                    profitNum += (int)(betUpDownVal * profitPer);
                }
                if (lastNum == 17)
                {
                    profitPer += 1;
                    profitNum += (int)(betUpDownVal * profitPer);
                }
                if (lastNum == 18)
                {
                    profitPer += 1.25;
                    profitNum += (int)(betUpDownVal * profitPer);
                }
                if (lastNum == 19)
                {
                    profitPer += 1.5;
                    profitNum += (int)(betUpDownVal * profitPer);
                }
                if (lastNum == 20)
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
