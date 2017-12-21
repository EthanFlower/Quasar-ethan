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


        List<Turn> turns;
        int turnAmount = 5;
        int active turn
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
        private Betting betting;
        private Die die;
        private Turn turn;
        //private Array Strings = new Array[]{"Youwentver!", "Rolled:" }; trying to have preset strings. possibly doing in future update
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < turnAmount; i++)
            {
                turns.Add(new WindowsFormsApplication1.Turn(this));

            }
            betSet();
            dieSet();
            turnSet();
        }
        private void betSet() {
            betting = new Betting(this);
        }
        private void dieSet()
        {
            die = new Die(this);
        }
        private void turnSet()
        {
            turn = new Turn(this);
        }

        public void die18_Click(object sender, EventArgs e)
        {
            dieSet();
            currentTurn.turnTotal += die.rolled(1, 8);
        }

        public void die47_Click(object sender, EventArgs e)
        {
            dieSet();
            die.rolled(4, 7);
        }

        public void button3_Click(object sender, EventArgs e)
        {
            turnSet();
            //have turn change when fold && give money back
            if (turn.foldTOrNextF == true)
            {
                turn.prepNextRound();
            }//button is then used to start the new round
            else if (turn.foldTOrNextF == false)
            {
                turn.nextRound();
            }
        }
        public void betButt_Click(object sender, EventArgs e)
        {
            betSet();
            betting.setBet();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        turnSet();
        betSet();
        turn.newRound();
        betUpDown.Minimum = (betting.totalMoney / 50) * 11;//min bet amount made so you have to win to keep playing
        }
    }

}
