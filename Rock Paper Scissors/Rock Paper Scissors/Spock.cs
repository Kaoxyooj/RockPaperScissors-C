using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Spock : Iwinorlose
    {
        string spoc;
        int spocNum = 3;

        public Spock(string spoc,int spocNum)
        {
            string _spoc = spoc;
            int _spocNum = spocNum;
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
