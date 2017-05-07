using System;


class EmployeeData
{
    static void Main()
    {
        Console.Write("Enter First name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter Age: ");
        byte age = byte.Parse(Console.ReadLine());

        Console.Write("Enter Gender (m or f): ");
        string gender = Console.ReadLine();

        Console.Write("Enter Personal ID number(e.g. 8306112507): ");
        int personalID = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Unique number(e.g 2756000): ");
        int uniqueNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID number: {4}\nUnique Enmployee number: {5}", firstName, lastName, age, gender, personalID, uniqueNumber);

    }
}
