using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class HowMany
    {
        Player1 player1 = new Player1();
        Player2 player2 = new Player2();
        UserName name = new UserName();


        string numOfPlayers;


        public  HowMany(string numOfPlayers)
        {
           this.numOfPlayers = numOfPlayers;                      
        }

        public string amountOfPlayers()
        {
            Console.Write("How many players are there?");
            string numOfPlayers = Console.ReadLine();
            return numOfPlayers;
        }
    }
}
