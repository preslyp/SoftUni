using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CategorizeNumbers
{
    static void Main()
    {

        
        string arrString = Console.ReadLine();

        string[] items = arrString.Split(' ');

        List<int> arr = new List<int> { items };

        double[] arr = new double[items.Length];

        int newInt;

   
        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i]==(int)arr[i])
            {
                newInt = int.Parse(items[i]);
            }
            else
            {
               arr[i] = double.Parse(items[i]);
            }
             Console.WriteLine(arr[i]);
        }

     
       
    }
}
