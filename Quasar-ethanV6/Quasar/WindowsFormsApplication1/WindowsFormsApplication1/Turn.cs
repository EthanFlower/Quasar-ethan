using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    partial class Form1
    {

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
            profitLb.Text = "";
            die18.Enabled = false;
            die47.Enabled = false;
            button3.Enabled = false;//fold
            betUpDown.Enabled = true;
            betButt.Enabled = true;
        }

        private void prepNextRound() {
            getNewMnyValue();
            die18.Enabled = false;
            die47.Enabled = false;
            button3.Text = "Next Round";
            foldTOrNextF = false;
        }
        private void nextRound() {
            newRound();
            button3.Text = "Fold";
            foldTOrNextF = true;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            newRound();
        }
    }
}
