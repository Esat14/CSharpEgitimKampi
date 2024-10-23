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
            Console.Write(" C# eğitim kampı sınav uygulaması");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("sınıfta kaç öğrenci var");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string[] studentNames = new string[studentCount];
            double[] stundentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz");
                    double value = double.Parse(Console.ReadLine());

                    totalExamResult += value;


                }
                Console.WriteLine();
                stundentExamAvg[i] = totalExamResult / 3;

            }
            for (int i = 0; i < studentCount; i++)
            {

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin sınav ortalaması {stundentExamAvg[i]}");
                if (stundentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} dersi geçemedi");
                }
            }













            Console.Read();
        }
    }
}
