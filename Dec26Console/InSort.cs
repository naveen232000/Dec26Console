using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec26Console
{
    internal class InSort
    {
        public static void Insort(int[]arr)
        {
            int n=arr.Length;
            Console.WriteLine("\nInsertion  sort O/p");
            for (int i = 0; i < n; i++)
            {
                int first = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > first)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = first;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
        public static void Insort2(int[] arr) {
            int n = arr.Length, i, j, val, flag;
            Console.WriteLine("\nMethod 2 Insertion : ");
            for (i = 1; i < n; i++)
            {
                val = arr[i]; flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else { 
                        flag = 1; 
                    }
                }
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }

    }
}

