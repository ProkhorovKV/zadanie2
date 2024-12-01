using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите количество чисел Фибоначчи, которые нужно вывести: ");
            int N = int.Parse(Console.ReadLine());

         
            for (int i = 0; i < N; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.WriteLine();
        }

        
        static long Fibonacci(int n)
        {
            
            if (n == 0) return 0;  
            if (n == 1) return 1;  

            
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
