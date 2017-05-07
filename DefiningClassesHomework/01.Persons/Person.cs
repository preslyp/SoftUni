using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Person
{
    private string name;
    private int age;
    private string email;
    public string Name {
        get
        {
            return this.name;
        }
        set
        {
            if (value == null || value == "")
            {
                throw new NullReferenceException("Name can't not be null");
            }
            this.name = value;
        } 
    }
    public int Age { 
        get
        {
            return this.age;
        }
        set
        {
            if (value< 0 || value > 100)
            {
                 throw new NullReferenceException("Age must be in the in the range [1 ... 100]");
            }
            this.age = value;
        }
    }
    public string Email { 
        get
        {
            return this.email;
        }
        set
        {
            if (value != "" && !value.Contains("@"))
            {
                throw new NullReferenceException("Invalid email");
            }
            this.email = value; 
        }
    }

    public Person(string name, int age, string email = null)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public override string ToString()
    {
        string result = String.Format("Name: {0};  Age: {1}; ", this.Name, this.Age);

        if (this.Email != "")
        {
            result += "Email: " + this.Email;
           
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter your email: ");
        string email = Console.ReadLine();

        Person person = new Person(name, age, email);
        Console.WriteLine(person);
       
    }
}
