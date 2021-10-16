using System;

class Program
{
    static void Main(string[]args)
    {
        Console.Write("Enter and integer: ");

        string line = Console.ReadLine();

        int value;
        Int32.TryParse(line, out value);

        if (value <10)
        {
            Console.WriteLine("This number is to small.");

        }
        else
        {
            Console.WriteLine("This number is big enough");
        }
    }

}
   