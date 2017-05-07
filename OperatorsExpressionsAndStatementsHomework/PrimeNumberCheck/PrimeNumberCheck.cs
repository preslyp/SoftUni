using System;

class PrimeNumberCheck
{
    static void Main()
    {
        string header = "n\tPrime?";
        Console.Write("Please enter positive integer number (0-100): ");
        int num = int.Parse(Console.ReadLine());

        if (num > 100)
        {
            Console.WriteLine("Please, enter valid integer.");
        }else if(num == 1)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}", num, "False");
        }else
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
			{
                if(num % i ==0)
                {
                    count++;
                }
			}

            bool isPrime = true;

            if (count > 2)
            {
                isPrime = false;
            }

            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine("{0}\t{1}", num, isPrime);
        }

    }
}