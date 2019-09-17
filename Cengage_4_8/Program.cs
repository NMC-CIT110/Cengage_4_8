using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cengage_4_8
{
    class Program
    {

        static void Main(string[] args)
        {
            //
            // variables
            //
            int numberCount = 3;
            int[] lotteryNumbers;
            int[] guessedNumbers;

            // **********************************************************
            // for testing 
            //
            // int[] lotteryNumbers = new int[] { 1, 4, 1 };
            // int[] guessedNumbers = new int[] { 1, 3, 1 };
            //

            lotteryNumbers = GetRandomLotteryNumbers(numberCount);
            guessedNumbers = GetUsersGuessedNumbers(numberCount);

            GetCorrectGuesses(lotteryNumbers, guessedNumbers, numberCount);



        }

        static int[] GetUsersGuessedNumbers(int numberCount)
        {
            throw new NotImplementedException();
        }

        static int[] GetRandomLotteryNumbers(int numberCount)
        {
            int[] lotteryNumbers = new int[numberCount];
            Random random = new Random();

            for (int index = 0; index < numberCount; index++)
            {
                lotteryNumbers[index] = random.Next(1, 5);
            }

            return lotteryNumbers;
        }

        static Boolean OrderMatchAll(int[] lotteryNumbers, int[] guessedNumbers, int numberCount)
        {
            bool match = true;

            for (int index = 0; index < numberCount; index++)
            {
                if (lotteryNumbers[index] != guessedNumbers[index])
                {
                    return match = false;
                }
            }

            return match;
        }

        static int[] GetCorrectGuesses(int[] lotteryNumbers, int[] guessedNumbers, int numberCount)
        {
            int[] correctGuesses = new int[numberCount];

            for (int guessedNumberIndex = 0; guessedNumberIndex < numberCount; guessedNumberIndex++)
            {
                for (int lotteryNumberIndex = 0; lotteryNumberIndex < numberCount; lotteryNumberIndex++)
                {
                    if (lotteryNumbers[lotteryNumberIndex] == guessedNumbers[guessedNumberIndex])
                    {
                        correctGuesses[guessedNumberIndex] = guessedNumbers[guessedNumberIndex];
                        lotteryNumbers[guessedNumberIndex] = 0;
                        break;
                    }

                }
            }

            return correctGuesses;
        }
    }
}
