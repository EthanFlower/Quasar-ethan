using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    class Turn
    {
        int turnTotal;

        public Turn(Form1 f)
        {
            form1 = f;
            turnTotal = 0;
            //make a die
        }
        //*
        public Turn(Die d)
        {
            die = d;
        }


        public Turn(Betting b)
        {
            betting = b;
        }//*/
        private Form1 form1;
        private Betting betting;
        public Betting Betting
        {
            get { return betting; }
            set { betting = value; }
        }


        private Die die;
        public Boolean foldTOrNextF;//form or here?
        public void newRound()
        {
            die = new Die(form1);
            betting = new Betting(form1);
            //allows for the customization of the game & used after each turn
            int totalMoney = betting.totalMoney;
            form1.mnyNum.Text = "" + totalMoney;
            form1.betUpDown.Maximum = totalMoney;//max bet amount
            form1.betUpDown.Value = form1.betUpDown.Minimum;//set starting bet to minimum
            die.lastNum = die.roll(1, 3);
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
            betting = new Betting(form1);
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
