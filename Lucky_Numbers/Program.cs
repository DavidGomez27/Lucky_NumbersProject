using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string playAgain;
            do
            {



                Console.WriteLine("Hello. You will be playing for a chance to win our lottery by choosing six \trandom numbers");

                Console.WriteLine("Please start by choosing your lowest starting number to set up a range");

                int lowNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Now, please choose your highest endng number");

                int highNum = int.Parse(Console.ReadLine());

                while (highNum <= lowNum)
                {
                    Console.WriteLine("second number must be greater than your first");
                }

                Console.WriteLine("Now pick your 6 numbers");




                // to get the users imput in array create 6 array with read line. assign j to guessed numbers to store in "guessedNumbers"
                int[] triedNumbers = new int[6];



                for (int i = 0; i < 6; i++)
                {
                    int guessedNumber = int.Parse(Console.ReadLine());

                    triedNumbers[i] = guessedNumber;

                }

                //to generate the randoms i just did the same as above but with the Random  rando = new Random which will populate with random numbers due to assigned with j low high num plus 1

                int[] winningNums = new int[6];

                Random rando = new Random();

                for (int j = 0; j < winningNums.Length; j++)
                {
                    int winningNumbers = rando.Next(lowNum, highNum) + 1;

                    winningNums[j] = winningNumbers;
                }


                foreach (int n in winningNums)
                {
                    Console.WriteLine("Lucky Number: " + n);
                }




                double jackpot = 1000000d;

                int matchedNumber = 0;

                for (int i = 0; i < triedNumbers.Length; i++)
                {
                    for (int j = 0; j < winningNums.Length; j++)
                    {
                        if (triedNumbers[i] == winningNums[j])
                        {
                            matchedNumber++;
                        }
                    }
                }






                if (matchedNumber == 6)
                {
                    Console.WriteLine("You guessed all 6 correctly! You win $" + jackpot);
                }
                else if (matchedNumber == 5)
                {
                    Console.WriteLine("You guessed 5 numbers correctly! You win $" + (jackpot * .83333));
                }
                else if (matchedNumber == 4)
                {
                    Console.WriteLine("You guessed 4 numbers correctly! You win $" + (jackpot * .66666));
                }
                else if (matchedNumber == 3)
                {
                    Console.WriteLine("You guessed 3 numbers correctly!You win $" + (jackpot * .5));
                }
                else if (matchedNumber == 2)
                {
                    Console.WriteLine("You guessed 2 numbers correctly! You win $" + (jackpot * .33333));
                }
                else if (matchedNumber == 1)
                {
                    Console.WriteLine("You guessed 1 number correctly! You win $" + (jackpot * .16666));
                }
                else
                {
                    Console.WriteLine("You didnt match any numbers. You lose");
                }





                Console.WriteLine("Would you like to play again? Type \"yes\" or \"no\"");
                playAgain = Console.ReadLine().ToLower();
            }
            while (playAgain == "yes");
          if (playAgain == "no")
            {
                Console.WriteLine("Thanks for playing.");
            }

            
           
        }
    }
}
