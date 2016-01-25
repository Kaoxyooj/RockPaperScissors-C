using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class Rock : Iwinorlose
    {
        string rock;
        int rockNum = 0;

        public Rock(string rock,int rockNum)
        {
            string _rock = rock;
            int _rockNum = rockNum;
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
