using System;

namespace SelectionFun
{
    class Program
    {
        static void Main(string[] args)
        {


            var favoriteNum = 7;
            Console.WriteLine("Can you guess my favorite number?");
            Console.WriteLine($"Enter it here");
            var userInput = int.Parse(Console.ReadLine());


            if (userInput < 7)
            { Console.WriteLine("Good guess, but it's too low"); }



            else if (userInput > 7)
            { Console.WriteLine("Good guess, but it's too high"); }





            else
            Console.WriteLine("Bingo!");














        }
    }
}
