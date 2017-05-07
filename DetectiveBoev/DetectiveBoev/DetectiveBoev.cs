using System;

namespace DetectiveBoev
{
    class DetectiveBoev
    {
        static void Main()
        {
            //input
            string secretWord = Console.ReadLine();
            string message = Console.ReadLine();
            string decryptedMassage = "";

            int asciiSum = 0;
            int mask = 0;
         
            //logic

            //Вади буквата от стринга като автоматично го правим масив - заучавам го
            foreach (char charCode in secretWord)
            {
                asciiSum += charCode;
            }
            //вади отделните числа от сумата докато не стигне нулата - заучавам го

            do
            {
                mask = 0;
                while (asciiSum > 0)
                {
                    mask += asciiSum % 10; //вади отделните числа от сумата докато не стигне нулата - заучавам го
                    asciiSum /= 10;
                }

                asciiSum = mask;

            } while (mask / 10 > 0);

            for (int i = message.Length - 1; i >= 0; i--)
            {
                char c = message[i];
                if (c % mask == 0)
                {
                    decryptedMassage += (char)(c + mask);
                }
                else
                {
                    decryptedMassage += (char)(c - mask);
                }
            }
            
            //output

            Console.WriteLine(decryptedMassage);
        }
    }
}
