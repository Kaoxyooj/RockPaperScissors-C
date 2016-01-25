using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class AI
    {
        Random random = new Random();
        string randomNumber;

        public int Ai(int randomNumber)
        {
            randomNumber = random.Next(0, 5);
            switch (randomNumber)
            {
                case 0:
                    Console.WriteLine("Rock");
                    break;
                case 1:
                    Console.WriteLine("Paper");
                    break;
                case 2:
                    Console.WriteLine("Scissor");
                    break;
                case 3:
                    Console.WriteLine("Spock");
                    break;
                case 4:
                    Console.WriteLine("Lizard");
                    break;
            }
            return randomNumber;
        }
    }
}
