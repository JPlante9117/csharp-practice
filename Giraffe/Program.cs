using System;
using System.Collections.Generic;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            //LIST OF STRINGS

            //List<string> names = new List<string> { "<name>", "Ana", "Jacques" };

            //names.Add("Kendra");
            //names.Add("Scott");
            //names.Add("Alex");
            //names.Remove("<name>");
            //foreach (var name in names)
            //{
            //    Console.WriteLine($"Hello, {name}");
            //}

            //names.Sort();

            //foreach (var name in names)
            //{
            //    Console.WriteLine($"Hi there, {name}");
            //}

            //var index = names.IndexOf("Betty");
            //if (index == -1)
            //{
            //    Console.WriteLine("Name not found");
            //}
            //else
            //{
            //    Console.WriteLine($"Found {names[index]} is at index {index}");
            //}

            var fibonacciNumbers = new List<int> { 1, 1 };
            for (int i = fibonacciNumbers.Count; i < 20; i++)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }

        }

    }
}
