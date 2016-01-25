using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Web.Script.Serialization;


namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool replay1 = true;
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();
            UserHand1player OnePlayer = new UserHand1player();
            UserHand2players TwoPlayers = new UserHand2players();
            HowMany howMany = new HowMany("");
            string p1Name;
            string p2Name;
            UserName player1Name = new UserName();

            
            
            


            switch (howMany.amountOfPlayers()) {
                case "1":
                    {
                            Console.WriteLine("What is your name Player 1?");                          
                            p1Name = player1.askName();
                        while (replay1)
                        {
                            OnePlayer.askHand(p1Name);                           
                            Console.ReadKey();
                            Console.WriteLine("New game "+ p1Name+"? Press Y to play again. / Press any key to quit.");
                            ConsoleKeyInfo cki = Console.ReadKey();
                            replay1 = cki.KeyChar == 'y';
                        }
                        break;
                    }
                case "2":
                    {
                            Console.WriteLine("What is your name Player1?");
                            p1Name = player1.askName();
                            Console.WriteLine("What is your name Player2?");
                            p2Name = player2.askName();
                        while (replay1)
                        {
                            TwoPlayers.askHand(p1Name,p2Name);
                            Console.ReadKey();
                            Console.WriteLine("New game? Press Y to play again. / Press any key to quit.");
                            ConsoleKeyInfo cki = Console.ReadKey();
                            replay1 = cki.KeyChar == 'y';                          
                        }
                        break;
                    }
        }
        }
    }
}

