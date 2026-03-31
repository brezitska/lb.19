using System;
using System.Text;

namespace Lab19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Лабораторна робота №19. Варіант 3");

            Console.Write("Введіть тризначне число k (від 100 до 999): ");
            int k = int.Parse(Console.ReadLine()!);

            string strK = k.ToString();

            Console.WriteLine($"\nЧисло k = {k}");
            Console.WriteLine($"Рядок k = \"{strK}\"");
            Console.WriteLine($"Довжина рядка = {strK.Length} (має бути 3)\n");

            char C2 = strK[0];
            char C1 = strK[1];
            char C0 = strK[2];

            Console.WriteLine("Присвоюємо символи:");
            Console.WriteLine($"C2 (ліва цифра)  = '{C2}'");
            Console.WriteLine($"C1 (середня цифра) = '{C1}'");
            Console.WriteLine($"C0 (права цифра)  = '{C0}'");

            Console.WriteLine("\nГотово! Натисніть будь-яку клавішу...");
            Console.ReadKey();
        }
    }
}