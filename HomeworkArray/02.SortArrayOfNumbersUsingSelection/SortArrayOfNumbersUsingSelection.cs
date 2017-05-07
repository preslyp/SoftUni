using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayOfNumbersUsingSelection
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        string[] items = inputStr.Split(' ');
        int[] intArr = new int[items.Length];

        for (int i = 0; i < intArr.Length; i++)
        {
            intArr[i] = int.Parse(items[i]);
        }

        int temp = 0;

        for (int i = 0; i < intArr.Length; i++)
        {
            for (int j = 0; j < intArr.Length - 1; j++)
            {
                if (intArr[j] > intArr[j + 1])
                {
                    temp = intArr[j + 1];
                    intArr[j + 1] = intArr[j]; 
                    intArr[j] = temp; 
                }
            }           
        }

        foreach (int item in intArr) Console.Write(item + " ");
    }
}
