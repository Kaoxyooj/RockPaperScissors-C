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
    class UserHand1player
    {
        Rock rock = new Rock("",0);
        Paper paper = new Paper("",1);
        Scissor scissor = new Scissor("",2);
        Spock spock = new Spock("", 3);
        Lizard lizard = new Lizard("", 4);
        Player1 player1 = new Player1();
        AI computer = new AI();
        PlayerChooseHand player1Hand = new PlayerChooseHand();
        int ptally = 0;
        int ctally = 0;




        public int askHand(string name)
        {
            //string createText = "scores" + Environment.NewLine;
            //File.WriteAllText(@"C:\", createText);
            string scoreText = File.ReadAllText(@"C:\score.txt");
            Console.WriteLine("Choose a strategy {0}.", name);
            Console.WriteLine("0 = Rock, 1 = Paper, 2 = Scissor, 3 = Spock, 4 = Lizard");
            switch (player1Hand.askHand())
            {
                case "0":
                    if (playGameRock(name) == 1)
                    {
                        ptally++;
                        Console.WriteLine("Your score: {0}",ptally);
                        Console.WriteLine("Ai's score: {0}" ,ctally);
                        return ptally;
                    }
                    else 
                    {
                        ctally++;
                        System.IO.File.WriteAllText(@"C:\score.txt", "Ai's score");
                        File.WriteAllText(@"C:\score.txt", ctally.ToString());
                        Console.WriteLine("Your score: {0}", ptally);
                        Console.WriteLine("Ai's score: {0}" ,ctally);
                        Console.WriteLine(scoreText);
                        return ctally;
                    }
                    return ptally;
                    break;
                case "1":
                    if (playGamePaper(name) == 1)
                    {
                        ptally++;
                        Console.WriteLine("Your score: {0}", ptally);
                        Console.WriteLine("Ai's score: {0}", ctally);
                        return ptally;
                    }
                    else 
                    {
                        ctally++;
                    Console.WriteLine("Your score: {0}", ptally);
                    Console.WriteLine("Ai's score: {0}", ctally);
                    }
                    return ptally;
                    break;
                case "2":
                    if (playGameScissor(name) == 1)
                    {
                        ptally++;
                        Console.WriteLine("Your score: {0}", ptally);
                        Console.WriteLine("Ai's score: {0}", ctally);
                        return ptally;
                    }
                    else 
                    {
                        ctally++;
                    Console.WriteLine("Your score: {0}", ptally);
                    Console.WriteLine("Ai's score: {0}", ctally);
                    }
                    return ptally;
                    break;
                case "3":
                    if (playGameSpock(name) == 1)
                    {
                        ptally++;
                        Console.WriteLine("Your score: {0}", ptally);
                        Console.WriteLine("Ai's score: {0}", ctally);
                        return ptally;
                    }
                    else
                    {
                        ctally++;
                    Console.WriteLine("Your score: {0}", ptally);
                    Console.WriteLine("Ai's score: {0}", ctally);
                    return ptally;
                    }
                    break;
                case "4":
                    if (playGameLizard(name) == 1)
                    {
                        ptally++;
                        Console.WriteLine("Your score: {0}", ptally);
                        Console.WriteLine("Ai's score: {0}", ctally);
                        return ptally;
                    }
                    else
                    {
                        ctally++;
                    Console.WriteLine("Your score: {0}", ptally);
                    Console.WriteLine("Ai's score: {0}", ctally);
                    }
                    return ptally;
                    break;
                default:
                    Console.WriteLine("Not a valid choice!");
                    return ptally;
                    break;
            }         
        }

        public int playGameRock(string name)
        {
            Console.WriteLine("{0} chose Rock.",name);
            Console.WriteLine("Ai chose...");
            int AiChoice = computer.Ai(0);
            int winner = (5 + 0 - AiChoice) % 5;
            
            switch (winner)
            {
                case 1:
                    rock.win();
                    return 1;
                    break;
                case 3:
                    rock.win();
                    return 1;
                    break;
                case 0:
                    rock.tie();
                    return 0;
                    break;
                default:
                    rock.lose();
                    return 2;
                    break;                                  
            }
            
            
        }

        public int playGamePaper(string name)
        {
            Console.WriteLine( "{0} chose Paper." , name);
            Console.WriteLine("Ai chose...");
            int AiChoice = computer.Ai(0);
            int winner = (5 + 1 - AiChoice) % 5;
            switch (winner)
            {
                case 1:
                    paper.win();
                    return 1;
                    break;
                case 3:
                    paper.win();
                    return 1;
                    break;
                case 0:
                    paper.tie();
                    return 0;
                    break;
                default:
                    paper.lose();
                    return 2;
                    break;
            }
            
        }
        public int playGameScissor(string name)
        {
            Console.WriteLine("{0} chose Scissor.",name);
            Console.WriteLine("Ai chose...");
            int AiChoice = computer.Ai(0);
            int winner = (5 + 2 - AiChoice) % 5;
            switch (winner)
            {
                case 1:
                    scissor.win();
                    return 1;
                    break;
                case 3:
                    scissor.win();
                    return  1;
                    break;
                case 0:
                    scissor.tie();
                    return 0;
                    break;
                default:
                    scissor.lose();
                    return 2;
                    break;
            }
            
        }

        public int playGameSpock(string name)
        {
            Console.WriteLine("{0} chose Spock.",name);
            Console.WriteLine("Ai chose...");
            int AiChoice = computer.Ai(0);
            int winner = (5 + 3 - AiChoice) % 5;
            switch (winner)
            {
                case 1:
                    spock.win();
                    return 1;
                    break;
                case 3:
                    spock.win();
                    return 1;
                    break;
                case 0:
                    spock.tie();
                    return 0;
                    break;
                default:
                    spock.lose();
                    return 2;
                    break;
            }
            
        }

        public int playGameLizard(string name)
        {
            Console.WriteLine("{0} chose Lizard.",name);
            Console.WriteLine("Ai chose...");
            int AiChoice = computer.Ai(0);
            int winner = (5 + 4 - AiChoice) % 5;
            switch (winner)
            {
                case 1:
                    lizard.win();
                    return 1;
                    break;
                case 3:
                    lizard.win();
                    return 1;
                    break;
                case 0:
                    lizard.tie();
                    return 0;
                    break;
                default:
                    lizard.lose();
                    return 2;
                    break;
            }                    
        }
        public int myScore(int ptally)
        {
            
            Console.WriteLine(ptally);
            return ptally;
        }
        public void Hey()
        {
            File.WriteAllText(@"C:\score.txt", ctally.ToString());
        }
    }
}
