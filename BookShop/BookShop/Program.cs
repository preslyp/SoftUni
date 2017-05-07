using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class Program
    {
        static void Main()
        {
            Book book = new Book("Pod Igoto", "Ivan Vazov", 15.90);
            Console.WriteLine(book);

            GoldenEditionBook newbook = new GoldenEditionBook("Tutun", "Dimitar Dimov", 22.90);
            Console.WriteLine(newbook);
        }
    }
}
