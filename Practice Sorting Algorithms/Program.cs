using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Practice_Sorting_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 6, 4, 1, 3, 9, 10, 5, 2, 8 };

            SortingAlgorithms.SortWay ascending = new SortingAlgorithms.SortWay(Ascending);
            SortingAlgorithms.SortWay descending = new SortingAlgorithms.SortWay(Descending);

            MergeSort merge = new MergeSort();
            merge.Sorting(arr, 0, arr.Length - 1);
            merge.PrintAll(arr);

            ResetArray(arr);

            merge.Sorting(arr, descending, 0, arr.Length - 1);
            merge.PrintAll(arr);

        }

        static void ResetArray(int[] arr)
        {
            arr = new int[] { 7, 6, 4, 1, 3, 9, 10, 5, 2, 8 };
        }

        static bool Ascending(int x, int y)
        {
            return x > y;
        }

        static bool Descending(int x, int y)
        {
            return x < y;
        }
    }
}