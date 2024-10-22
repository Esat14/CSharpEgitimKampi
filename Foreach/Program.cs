using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for(int i = 2; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
