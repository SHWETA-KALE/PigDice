using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            
            Console.WriteLine("Let's Play PIG!");

            int turn = 1;


            int turnScore = 0;
            int totalScore = 0;
            

            Random random = new Random();

            Console.WriteLine($"Turn {turn}");

            while (totalScore < 20)
            {
                

                Console.WriteLine("Enter 'r' to roll again and 'h' to hold");

                int roll = random.Next(1, 7);
                char userPresses = Console.ReadKey().KeyChar;
                Console.ReadLine();

                if (userPresses == 'r')
                {
                    if (roll == 1)
                    {
                        Console.WriteLine($"You rolled: {roll}\n" + $"Turn Over. No score");  //turn ends
                        turnScore = 0;
                        Console.WriteLine("==============================================");
                        turn++;
                        totalScore = totalScore + turnScore;
                        Console.WriteLine($"Turn {turn}");
                        continue; //starts with new turn immediately
                    }


                    Console.WriteLine($"you rolled: {roll}");
                    turnScore = turnScore + roll;
                    

                    Console.WriteLine($"Your turn score is: {turnScore}");
                    Console.WriteLine($"Your total score is: {totalScore}");


                    Console.WriteLine($"if you hold, you will have {turnScore} points ");
                    

                    
                }
                else if (userPresses == 'h')
                {
                    
                    Console.WriteLine("=============================================================");
                    totalScore += turnScore;
                    Console.WriteLine($"Your turn score is: {turnScore}");
                    Console.WriteLine($"Your total score is: {totalScore}");

                    turn++;
                    turnScore = 0;
                    Console.WriteLine("==============================================================");
                    Console.WriteLine($"Turn {turn}");

                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'r' to roll or 'h' to hold.");
                    continue;
                }

            }
            Console.WriteLine($"Congratulations! You won!.");
            

            Console.WriteLine($"Thankyou for playing this game your totalscore is {totalScore} and you achieved it in {turn} turns.");

            Console.ReadKey();
        }



        

        
    }
}
