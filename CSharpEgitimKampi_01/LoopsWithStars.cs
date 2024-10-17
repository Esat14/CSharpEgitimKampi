using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi_01
{
    internal class LoopsWithStars
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("a+");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
