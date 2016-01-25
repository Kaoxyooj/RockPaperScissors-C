using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class Paper : Iwinorlose
    {
        string paper;
        int paperNum = 1;

        public Paper(string paper,int paperNum)
        {
           string _paper = paper;
           int _paperNum = paperNum;
        }

        public void lose()
        {
            Console.WriteLine("You lose!");
        }

        public void tie()
        {
            Console.WriteLine("It's a tie!");
        }

        public void win()
        {
            Console.WriteLine("You Win!");
        }
    }
}
