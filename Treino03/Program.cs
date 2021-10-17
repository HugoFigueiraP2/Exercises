using System;
using System.Collections.Generic;
using System.Linq;

namespace Treino03
{
    class Program
    {
        static void Main()
        {
            const int inputCount = 4;
            var inputValues = new List<int>(inputCount);
            Console.WriteLine($"Enter {inputCount} numbers to calculate the average");
            Console.WriteLine("If you don´t mind of course ;D");
            for(var i = 0; i < inputCount; i++)
            {
                var userInput = Console.ReadLine();
                if (int.TryParse(userInput, out var intIHope))
                {
                    inputValues.Add(intIHope);
                }
                else
                {
                    Console.WriteLine("I told you to enter numbers. I wanted integers.");
                    Console.WriteLine("Run the program again with integers!");
                }
            }
            Console.WriteLine(
                $"The average of {string.Join(", ", inputValues)} is {inputValues.Sum() / inputCount}");
        }
    }
}