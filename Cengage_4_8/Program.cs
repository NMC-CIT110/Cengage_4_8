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
            int numberCount = 3;
            //int[] lotteryNumbers = new int[] { 1, 4, 1 };
            int[] lotteryNumbers = GetRandomLotteryNumbers(numberCount);
            int[] guessedNumbers = new int[] { 1, 3, 1 };

            GetCorrectGuesses(lotteryNumbers, guessedNumbers, numberCount);



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
