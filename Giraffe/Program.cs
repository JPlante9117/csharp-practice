using System;
using System.Collections.Generic;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "<name>", "Ana", "Jacques" };

            names.Add("Kendra");
            names.Add("Scott");
            names.Add("Alex");
            names.Remove("<name>");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello, {name}");
            }

            names.Sort();

            foreach (var name in names)
            {
                Console.WriteLine($"Hi there, {name}");
            }

            var index = names.IndexOf("Betty");
            if (index == -1)
            {
                Console.WriteLine("Name not found");
            }
            else
            {
                Console.WriteLine($"Found {names[index]} is at index {index}");
            }
        }

    }
}
