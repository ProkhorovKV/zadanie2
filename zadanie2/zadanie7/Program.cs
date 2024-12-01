using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            
            int result = GCD(a, b);

            
            Console.WriteLine($"Наибольший общий делитель ({a}, {b}) = {result}");
        }

        // Алгоритм Евклида
        static int GCD(int a, int b)
        {
            
            if (b == 0)
            {
                return a;
            }

            
            return GCD(b, a % b);
        }
    }
}
