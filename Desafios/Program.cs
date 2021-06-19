using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafios
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());

            for (var i = 0; i < totalDeCasosDeTeste; i++)
            {
                var list = Console.ReadLine().Split();
                var orderedList = list.OrderBy(x=>x);
                var finalList = new HashSet<string>(orderedList);

                var count = 0;
                foreach (var item in finalList)
                {
                    if (count == 0)
                    {
                        Console.Write(item);
                    }
                    else
                    {
                        Console.Write(" " + item);    
                    }

                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}