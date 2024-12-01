using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            
            Console.WriteLine("Среднее значение: " + CalculateAverage(numbers, numbers.Length));
        }

        
        static double CalculateAverage(int[] arr, int n)
        {
            
            if (n == 1)
            {
                return arr[0];
            }
            else
            {
                
                return (CalculateAverage(arr, n - 1) * (n - 1) + arr[n - 1]) / n;
            }
        }
    }
}
