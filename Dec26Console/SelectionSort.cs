using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec26Console
{
    internal class SelectionSort
    {
        static void SelectSort(int[] arr)
        {
            int array_size=arr.Length;
            int tmp, min_key;
            for (int j = 0; j < array_size - 1; j++)
            {
                min_key = j;
                for (int k = j + 1; k < array_size; k++)
                {
                    if (arr[k] < arr[min_key])
                    {
                        min_key = k;
                    } 
                }
                tmp = arr[min_key];
                arr[min_key] = arr[j];
                arr[j] = tmp; 
            }
            //Console.WriteLine("The Array After Selection Sort is: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
        }
        static void PrintSelectSort(int[] arr)
        {
            int n = arr.Length;
            Console.WriteLine("\nSelection Sort o/p");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] nums = { 4, 2, 1, 8, 3 };
            SelectSort(nums);
            PrintSelectSort(nums);
            Console.Read();
        }
    }
}
