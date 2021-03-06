﻿using System;
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
        private int lastRoll;
        public int lastNum = 0;
        public int roll(int min, int max)
        {
            return randNum.Next(min, max + 1);
        }
        public void rolled(int min, int max)
        {
            if (lastNum <= 20)
            {
                lastRoll = roll(min, max);
                lastNum += lastRoll;
            }
            if (lastNum > 20)
            {
                form1.wentOver.Text = "You went over!";
                form1.button3_Click(null, EventArgs.Empty);//forcibly activates button3 to end round. has no object or event
            }
            form1.label1.Text = "" + lastNum;
            form1.rollNum.Text = "Rolled:" + lastNum;//roll num
        }
    }
}
