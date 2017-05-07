using System;

class BankAccountData
{
    static void Main(string[] args)
    {
        Console.Write("Enter First name:");
        string firstName = Console.ReadLine();
        Console.Write("Enter Middle name:");
        string middleName = Console.ReadLine();
        Console.Write("Enter Last name:");
        string lastName = Console.ReadLine();
        Console.Write("Enter balance account:");
        decimal balance = decimal.Parse(Console.ReadLine());
        Console.Write("Enter bank name account:");
        string bankName = Console.ReadLine();
        Console.Write("Enter IBAN account:");
        string iBAN = Console.ReadLine();
        Console.Write("Enter number of first credit card:");
        string firstCreditCardNumber = Console.ReadLine();
        Console.Write("Enter number of second credit card:");
        string secondCreditCardNumber = Console.ReadLine();
        Console.Write("Enter number of third credit card:");
        string thirdCreditCardNumber = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Your name:{0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("balance:{0}", balance);
        Console.WriteLine("bank name:{0}", bankName);
        Console.WriteLine("IBAN: {0}", iBAN);
        Console.WriteLine("first credit card:{0}", firstCreditCardNumber);
        Console.WriteLine("second credit card:{0}", secondCreditCardNumber);
        Console.WriteLine("third credit card:{0}", thirdCreditCardNumber);
    }
}

