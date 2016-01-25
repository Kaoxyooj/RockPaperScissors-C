using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Scissor : Iwinorlose
    {
        string scissor;
        int scissorNum = 2;


        public Scissor(string scissor,int scissorNum)
        {
            string _scissor = scissor;
            int _scissorNum = scissorNum;
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
            Console.WriteLine("You win!");
        }
    }
}
