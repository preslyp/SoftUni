using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayOfNumbers
{
    static void Main()
    {
        string arrString = Console.ReadLine();

        string[] items = arrString.Split(' ');

        int[] arr = new int[items.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(items[i]);
        }

        Array.Sort(arr);

        foreach (int i in arr) Console.Write(i + " ");

        Console.WriteLine();
    }
}
