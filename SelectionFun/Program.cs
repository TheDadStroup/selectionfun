using System;

namespace SelectionFun
{
    class Program
    {
        static void Main(string[] args)
        {



            do
            {

                //var favNumber = 7;

                Console.WriteLine("Can you guess my favorite number?");
                  Console.WriteLine($"Enter it here");
                  var userInput = int.Parse(Console.ReadLine());

                if (userInput < 7)
                { Console.WriteLine("Good guess, but it's too low. Try again."); }



                else if (userInput > 7)
                { Console.WriteLine("Good guess, but it's too high. Try again."); }


                else
                //else if (userInput == 7)
                { Console.WriteLine("Bingo!");
                    break;
                }

                

            } while (true);
                











        }
    }
}
