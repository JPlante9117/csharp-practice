using System;
using System.Collections.Generic;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "<name>", "Ana", "Jacques" };
            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }
        }
    }
}
