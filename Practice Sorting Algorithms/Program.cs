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

            BubbleSort bubble = new BubbleSort();
            bubble.Sorting(arr);
            bubble.PrintAll(arr);

            ResetArray(arr);

            // 왜 안나와 왜 안나와
            bubble.Sorting(arr, descending);
            bubble.PrintAll(arr);

            ResetArray(arr);
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