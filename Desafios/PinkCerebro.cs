using System;

namespace Desafios
{
    public class PinkCerebro
    {
        public void Pink()
        {
            int two=0, three=0, four=0, five=0;
            
            var qntd = int.Parse(Console.ReadLine());

            var nums = Console.ReadLine().Split();

            foreach (var item in nums)
            {
                var num = int.Parse(item);

                if (num % 5 == 0) five++;
                if (num % 4 == 0) four++;
                if (num % 3 == 0) three++;
                if (num % 2 == 0) two++;
            }
            
            Console.WriteLine("{0} Multiplo(s) de 2", two);
            Console.WriteLine("{0} Multiplo(s) de 3", three);
            Console.WriteLine("{0} Multiplo(s) de 4", four);
            Console.WriteLine("{0} Multiplo(s) de 5", five);
        }
    }
}