using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Enter Company name:");
        string name = Console.ReadLine();
        Console.Write("Enter Your Address:");
        string adress = Console.ReadLine();
        Console.Write("Enter Your Phone:");
        string phone = Console.ReadLine();
        Console.Write("Enter Your Fax Number:");
        string fax = Console.ReadLine();
        Console.Write("Enter Your Web site:");
        string site = Console.ReadLine();
        Console.Write("Enter Manager First name:");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter Manager Last name:");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter Manager age:");
        sbyte age = sbyte.Parse(Console.ReadLine());
        Console.Write("Enter Manager phone:");
        string managerPhone = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("{0}", name);
        Console.WriteLine("Address: {0}", adress);
        Console.WriteLine("Tel. {0}", phone);
        if (fax == string.Empty)
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else Console.WriteLine("Fax: {0}", fax);
        Console.WriteLine("Web site: {0}", site);
        Console.WriteLine("Manager: {0}{1}{2}( age: {3}, tel. {4})", managerFirstName, string.Empty, managerLastName, age, managerPhone);
    }
}
