using System;

namespace Desafios
{
    public class Coordenadas
    {
        public void Coord()
        {
            double x, y;
        
            var input = Console.ReadLine();
        
            var values = input.Split(" ");
        
            x = double.Parse(values[0]);
            y = double.Parse(values[1]);
        
            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
        
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
        
            if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
        
            if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
        
            if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
        
            if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo X");
            }
        
            if (x != 0 && y == 0)
            {
                Console.WriteLine("Eixo Y");
            }
        }
        
    }
}