using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec26Console
{
    internal class Program
    {
        static void BSort(int[] arr)
        {
            int temp = 0,n=arr.Length;
            Console.WriteLine("\nBubble sort O/p");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(arr[j] + " ");
                    if (arr[j] >= arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                       
                    }
                    
                }
               
                Console.WriteLine("");
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

        }
        static void Main(string[] args)
        {
            int[] arr = { 74, 25, 31, 88, 13 };
            Console.WriteLine("Unsorted");
            for (int i = 0;i < arr.Length;i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            BSort(arr);
            InSort.Insort(arr);
            InSort.Insort2(arr);
            Console.ReadLine();
        }
    }
}
