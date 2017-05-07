using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOfNumbers
{
    class SortArrayOfNumbers
    {
        static void Main()
        {
            int temp = 0;

            string buble = Console.ReadLine();

            string[] items = buble.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] arr = new int[items.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(items[i]);
            }


            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }

                }

            }


            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");


        }
    }
}
