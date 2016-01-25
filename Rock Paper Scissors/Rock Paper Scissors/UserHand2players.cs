using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class UserHand2players
    {
        Rock rock = new Rock("", 0);
        Paper paper = new Paper("", 1);
        Scissor scissor = new Scissor("", 2);
        Spock spock = new Spock("", 3);
        Lizard lizard = new Lizard("", 4);
        Player1 player1 = new Player1();
        AI computer = new AI();
        PlayerChooseHand player1Hand = new PlayerChooseHand();
        PlayerChooseHand player2Hand = new PlayerChooseHand();
        string p1Hand;
        string p2Hand;
        int p1score = 0;
        int p2score = 0;

        public void askHand(string name1, string name2)
        {
            Console.Clear();
            Console.WriteLine("Choose a strategy.");
            Console.WriteLine(name1);
            Console.WriteLine("0 = Rock, 1 = Paper, 2 = Scissor, 3 = Spock, 4 = Lizard");
            p1Hand = player1Hand.askHand();
            Console.Clear();
            Console.WriteLine("Choose a strategy.");
            Console.WriteLine(name2);
            Console.WriteLine("0 = Rock, 1 = Paper, 2 = Scissor, 3 = Spock, 4 = Lizard");
            p2Hand = player2Hand.askHand();

            switch (p1Hand)
            {
                case "0":
                    if (p2Hand == "2" || p2Hand == "4")
                    {
                        if (p2Hand == "2")
                        {
                            p2Hand = "Scissor";
                        }
                        else if (p2Hand == "4")
                        {
                            p2Hand = "Lizard";
                        }
                        Console.WriteLine("{0} chose Rock, {1} chose {2}, {0} wins!", name1, name2, p2Hand);
                        p1score++;
                        Console.WriteLine("{0}'s score is: {1}", name1, p1score);
                        Console.WriteLine("{0}'s score is: {1}", name2, p2score);
                    }
                    else if (p2Hand == "1" || p2Hand == "3")
                    {
                        if (p2Hand == "1")
                        {
                            p2Hand = "Paper";
                        }
                        else if (p2Hand == "3")
                        {
                            p2Hand = "Spock";
                        }
                        Console.WriteLine("{0} chose Rock, {1} chose {2}, {1} wins!", name1, name2, p2Hand);
                        p2score++;
                        Console.WriteLine("{0}'s score is: {1}", name1, p1score);
                        Console.WriteLine("{0}'s score is: {1}", name2, p2score);
                    }
                    else
                    {
                        rock.tie();
                        Console.WriteLine("{0}'s score is: {1}", name1, p1score);
                        Console.WriteLine("{0}'s score is: {1}", name2, p2score);
                    }
                    break;
                case "1":
                    if (p2Hand == "0" || p2Hand == "3")
                    {
                        if (p2Hand == "3")
                        {
                            p2Hand = "Spock";
                        }
                        else if (p2Hand == "0")
                        {
                            p2Hand = "Rock";
                        }
                        Console.WriteLine("{0} chose Paper, {1} chose {2}, {0} wins!", name1, name2, p2Hand);
                        p1score++;
                        Console.WriteLine("{0}'s score is: {1}", name1, p1score);
                        Console.WriteLine("{0}'s score is: {1}", name2, p2score);
                    }
                    else if (p2Hand == "2" || p2Hand == "4")
                    {
                        if (p2Hand == "2")
                        {
                            p2Hand = "Scissor";
                        }
                        else if (p2Hand == "4")
                        {
                            p2Hand = "Lizard";
                        }
                        Console.WriteLine("{0} chose Paper, {1} chose {2}, {1} wins!", name1, name2, p2Hand);
                        p2score++;
                        Console.WriteLine("{0}'s score is: {1}", name1, p1score);
                        Console.WriteLine("{0}'s score is: {1}", name2, p2score);
                    }
                    else
                    {
                        paper.tie();
                        Console.WriteLine("{0}'s score is: {1}", name1, p1score);
                        Console.WriteLine("{0}'s score is: {1}", name2, p2score);
                    }
                    break;
                case "2":
                    if (p2Hand == "1" || p2Hand == "4")
                    {
                        if (p2Hand == "2")
                        {
                            p2Hand = "Scissor";
                        }
                        else if (p2Hand == "4")
                        {
                            p2Hand = "Lizard";
                        }
                        Console.WriteLine("{0} chose Scissor, {1} chose {2}, {0} wins!", name1, name2, p2Hand);

                        p1score++;
                        Console.WriteLine("{0}'s score is: {1}", name1, p1score);
                        Console.WriteLine("{0}'s score is: {1}", name2, p2score);
                    }
                    else if (p2Hand == "0" || p2Hand == "3")
                    {
                        if (p2Hand == "1")
                        {
                            p2Hand = "Paper";
                        }
                        else if (p2Hand == "3")
                        {
                            p2Hand = "Spock";
                        }
                        Console.WriteLine("{0} chose Scissor, {1} chose {2}, {1} wins!", name1, name2, p2Hand);
                        p2score++;
                        Console.WriteLine("{0}'s score is: {1}", name1, p1score);
                        Console.WriteLine("{0}'s score is: {1}", name2, p2score);
                    }
                    else
                    {
                        scissor.tie();
                        Console.WriteLine("{0}'s score is: {1}", name1, p1score);
                        Console.WriteLine("{0}'s score is: {1}", name2, p2score);
                    }
                    break;
                case "3":
                    if (p2Hand == "0" || p2Hand == "2")
                    {
                        if (p2Hand == "2")
                        {
                            p2Hand = "Scissor";
                        }
                        else if (p2Hand == "0")
                        {
                            p2Hand = "Rock";
                        }
                        Console.WriteLine("{0} chose Scissor, {1} chose {2}, {0} wins!", name1, name2, p2Hand);
                        p1score++;
                        Console.WriteLine("{0}'s score is: {1}", name1, p1score);
                        Console.WriteLine("{0}'s score is: {1}", name2, p2score);
                    }
                    else if (p2Hand == "1" || p2Hand == "4")
                    {
                        if (p2Hand == "1")
                        {
                            p2Hand = "Paper";
                        }
                        else if (p2Hand == "4")
                        {
                            p2Hand = "Spock";
                        }
                        Console.WriteLine("{0} chose Scissor, {1} chose {2}, {1} wins!", name1, name2, p2Hand);
                        p2score++;
                        Console.WriteLine("{0}'s score is: {1}", name1, p1score);
                        Console.WriteLine("{0}'s score is: {1}", name2, p2score);
                    }
                    else
                    {
                        spock.tie();
                        Console.WriteLine("{0}'s score is: {1}", name1, p1score);
                        Console.WriteLine("{0}'s score is: {1}", name2, p2score);
                    }
                    break;
                case "4":
                    if (p2Hand == "1" || p2Hand == "3")
                    {
                        if (p2Hand == "1")
                        {
                            p2Hand = "Paper";
                        }
                        else if (p2Hand == "3")
                        {
                            p2Hand = "Spock";
                        }
                        Console.WriteLine("{0} chose Lizard, {1} chose {2}, {0} wins!", name1, name2, p2Hand);
                        p1score++;
                        Console.WriteLine("{0}'s score is: {1}", name1, p1score);
                        Console.WriteLine("{0}'s score is: {1}", name2, p2score);
                    }
                    else if (p2Hand == "0" || p2Hand == "2")
                    {
                        if (p2Hand == "0")
                        {
                            p2Hand = "Rock";
                        }
                        else if (p2Hand == "2")
                        {
                            p2Hand = "Scissor";
                        }
                        Console.WriteLine("{0} chose Lizard, {1} chose {2}, {1} wins!", name1, name2, p2Hand);
                        p2score++;
                        Console.WriteLine("{0}'s score is: {1}", name1, p1score);
                        Console.WriteLine("{0}'s score is: {1}", name2, p2score);
                    }
                    else
                    {
                        spock.tie();
                        Console.WriteLine("{0}'s score is: {1}", name1, p1score);
                        Console.WriteLine("{0}'s score is: {1}", name2, p2score);
                    }
                    break;
            }
        }
    }
}
