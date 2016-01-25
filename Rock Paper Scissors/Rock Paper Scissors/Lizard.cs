using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Lizard : Iwinorlose
    {
        string lizard;
        int lizardNum = 4;

        public Lizard(string lizard,int lizardNum)
        {
            string _lizard = lizard;
            int _lizardNum = lizardNum;
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
