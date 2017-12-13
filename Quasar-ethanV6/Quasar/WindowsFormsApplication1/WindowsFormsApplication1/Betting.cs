using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    partial class Form1
    {

        private void setBet() {
            die18.Enabled = true;
            die47.Enabled = true;
            button3.Enabled = true;//fold
            betUpDown.Enabled = false;
            betButt.Enabled = false;
            totalMoney -= (int)betUpDown.Value;
            mnyNum.Text = "" + totalMoney;
        }

        private void getNewMnyValue()
        {
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
                profitLb.Text = "Profit: " + profitNum + ", " + profitPer * 100 + "% Of Bet";
            }
        }
    }
}
