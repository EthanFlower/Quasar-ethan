using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Die
    {
        public Random randNum = new Random();
        private Form1 form1 = new Form1();
        public int lastNumb = form1.lastNum;
        private int lastRoll;
        public int roll(int min, int max)
        {
            return randNum.Next(min, max + 1);
        }
   // }
   // partial class Form1
    //{
        public void rolled(int min, int max)
        {
            if (lastNumb <= 20)
            {
                lastRoll = roll(min, max);
                lastNumb += lastRoll;
                label1.Text = "" + lastNumb;
                rollNum.Text = "Rolled:" + lastRoll;
            }
            if (lastNumb > 20)
            {
                form1.wentOver.Text = "You went over!";
                form1.button3_Click(null, EventArgs.Empty);//forcibly activates button3 to end round. has no object or event
            }
        }
    }
}
