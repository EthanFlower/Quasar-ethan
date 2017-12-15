using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Turn
    {
        private Betting betting = new Betting();
        private Form1 form1 = new Form1(); 
        private Die die = new Die();
        public Boolean foldTOrNextF = true;//form or here?
        public void newRound()
        {
            //allows for the customization of the game & used after each turn
            int totalMoney = betting.totalMoney;
            form1.mnyNum.Text = "" + totalMoney;
            form1.betUpDown.Maximum = totalMoney;//max bet amount
            form1.betUpDown.Minimum = (totalMoney / 50) * 11;//min bet amount made so you have to win to keep playing
            form1.betUpDown.Value = form1.betUpDown.Minimum;//set starting bet to minimum
            die.lastNum = die.roll(1, 4);
            form1.label1.Text = "" + die.lastNum;
            form1.rollNum.Text = "Rolled: Nothing Yet";
            form1.wentOver.Text = "";
            form1.profitLb.Text = "";
            form1.die18.Enabled = false;
            form1.die47.Enabled = false;
            form1.button3.Enabled = false;//fold
            form1.betUpDown.Enabled = true;
            form1.betButt.Enabled = true;
        }

        public void prepNextRound() {
            betting.getNewMnyValue();
            form1.die18.Enabled = false;
            form1.die47.Enabled = false;
            form1.button3.Text = "Next Round";
            foldTOrNextF = false;
        }
        public void nextRound() {
            newRound();
            form1.button3.Text = "Fold";
            foldTOrNextF = true;
        }
    }
}
