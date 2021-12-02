using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_01_Any_All_Contains
{
    class Program
    {
        private static List<int> notas = new List<int> { 500, 600, 700, 800, 900 };
        static void Main(string[] args)
        {
            var any = notas.Any(n => n > 900);
            var all = notas.All(n => n > 400);
            var contains = notas.Contains(1000);

            Console.WriteLine("Any: " + any);
            Console.WriteLine("All: " + all);
            Console.WriteLine("Contains: " + contains);
        }
    }
}
