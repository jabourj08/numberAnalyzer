using System;
using System.Dynamic;

namespace numberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //NUMBER ANALYZER BEGIN

            //INTRO and Grab user's name
            Console.WriteLine("***** Hello, and welcome to the Number Analyzer! *****");
            Console.WriteLine();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            bool cont = true;
            
            //Begin loop for continuance
            while (cont)
            {
                bool odd;
                bool isNumber = true;
                int analyze = 0;

                Console.WriteLine(name + ", please enter a number between 1 and 100: ");
                string input = Console.ReadLine();
                
                //Begin loop to check for a valid number
                while (isNumber)
                {
                    //check for valid number
                    if (int.TryParse(input, out analyze))
                    {
                        //check for valid range
                        if (analyze < 1 || analyze > 100)
                        {
                            Console.WriteLine("Sorry, " + name + " that number is not in range. Please try again");
                            input = Console.ReadLine();
                        }
                        else
                        {
                            isNumber = false;
                        }                        
                    }
                    else
                    {
                        Console.WriteLine("Sorry, " + name + " that is not a number. Please try again");
                        input = Console.ReadLine();
                    }
                }   
                
                //Determine even or odd
                if (analyze % 2 == 0)
                {
                    odd = false;
                }
                else
                {
                    odd = true;
                }


                //Begin printout criteria
                if (odd && analyze > 60)
                {
                    Console.WriteLine(name + ", the number you entered is " + analyze + ". It is greater than 60, and it is an Odd number.");
                }
                else if (!odd && analyze >= 2 && analyze <= 24)
                {
                    Console.WriteLine(name + ", the number you entered is " + analyze + ". It is less than 25, and it is an Even number.");
                }
                else if (!odd && analyze >= 26 && analyze <= 60)
                {
                    Console.WriteLine(name + ", the number you entered is " + analyze + ". It is between than 25 and 61, and it is an Even number.");
                }
                else if (!odd && analyze > 60)
                {
                    Console.WriteLine(name + ", the number you entered is " + analyze + ". It is greater than 60, and it is an Even number.");
                }
                else if (odd)
                {
                    Console.WriteLine(name + ", the number you entered is " + analyze + ", and it is an Odd number.");
                }

                //prompt user for continuance
                Console.WriteLine("Would you like to continue and enter another number " + name + "? (enter y/n)");
                input = Console.ReadLine();
                input = input.ToLower();

                //determine continuance
                if (input[0] == 'y')
                {
                    cont = true;
                }
                else if (input[0] == 'n')
                {
                    cont = false;
                }

            }

            //Say goodbye and close program
            Console.WriteLine("Thank you " + name + " for using the Number Analyzer! Have a fantastic day!");
            Console.WriteLine("Goodbye!");

        }
    }
}
