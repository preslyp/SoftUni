using System;

class BullsAndCows
{
    static void Main()
    {
        int secretNumber = 2228;
        int bulls = 2;
        int cows = 1;

        for (int guessNumber = 1111; guessNumber <= 9999; guessNumber++)
        {
            int bullsFound = GetBulls(secretNumber, guessNumber);
            int cowsFound = GetCows(secretNumber, guessNumber);

            if (bulls == bullsFound && cows == cowsFound)
            {
                Console.Write(guessNumber);
                Console.WriteLine(" ");
            }
        }
    }

    private static int GetBulls(int secretNumber, int guessNumber)
    {
        char sec0 = secretNumber.ToString()[0];
        char sec1 = secretNumber.ToString()[1];
        char sec2 = secretNumber.ToString()[2];
        char sec3 = secretNumber.ToString()[3];

        char guess0 = guessNumber.ToString()[0];
        char guess1 = guessNumber.ToString()[1];
        char guess2 = guessNumber.ToString()[2];
        char guess3 = guessNumber.ToString()[3];
    }
}