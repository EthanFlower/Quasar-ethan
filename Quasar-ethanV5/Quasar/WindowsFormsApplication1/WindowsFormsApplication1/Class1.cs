using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Die {
        public Random randNum = new Random();
        public int roll(int min, int max){
            return randNum.Next(min, max + 1);
        }
    }
}
