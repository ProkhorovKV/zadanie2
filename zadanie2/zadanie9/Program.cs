using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = { 64, 25, 12, 22, 11 };

            Console.WriteLine("Исходный массив:");
            PrintArray(arr);

            
            SelectionSort(arr, 0);

            Console.WriteLine("\nОтсортированный массив:");
            PrintArray(arr);
        }

        
        static void SelectionSort(int[] arr, int index)
        {
            
            if (index >= arr.Length - 1)
                return;

            
            int minIndex = index;
            for (int i = index + 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }
            }

            // меняем местами
            if (minIndex != index)
            {
                int temp = arr[index];
                arr[index] = arr[minIndex];
                arr[minIndex] = temp;
            }

            
            SelectionSort(arr, index + 1);
        }

        // Вывод
        static void PrintArray(int[] arr)
        {
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
