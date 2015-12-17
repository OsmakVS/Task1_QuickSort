using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_QuickSort
{
    class Program
    {
        static void Sort(int[] arr, int left, int right)
        {
            int i = left;
            int j = right;
            int relem = arr[(left + right) / 2];
            while (i <= j)
            {
                while (arr[i] < relem) i++;
                while (arr[j] > relem) j--;
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            if (left < j) Sort(arr, left, j);
            if (i < right) Sort(arr, i, right);
        }
        static void Main(string[] args)
        {
            int[] arr = { 9, 5, 22, 12, 45, 56, 10, 0, 11, 88 };
            foreach (int arr1 in arr)
                Console.WriteLine(arr1 + " ");
            Console.WriteLine("Сортировка:");
            Sort(arr, 0, arr.Length - 1);
            foreach (int arr1 in arr)
                Console.WriteLine(arr1 + " ");
            Console.ReadLine();
        }
    }
}
