using System;

class StringsAndObjects
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World";

        object HelloWord = firstWord + " " + secondWord;

        string thirdWord = (string)HelloWord;

        Console.WriteLine(HelloWord);
        Console.WriteLine(thirdWord);
    }
}
