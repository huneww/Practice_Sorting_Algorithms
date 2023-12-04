using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sorting_Algorithms
{
    internal class InsertionSort : SortingAlgorithms
    {
        [Obsolete("This meathd is InsertionSort, Time Complexity is O(n^2)")]
        public new void Sorting(int[] arr, int startIdx = 0, int endIdx = -1)
        {
            Sorting(arr, (x, y) => { return x > y; }, startIdx, endIdx);
        }

        [Obsolete("This meathd is InsertionSort, Time Complexity is O(n^2)")]
        public new void Sorting(int[] arr, SortWay sortWay, int startIdx = 0, int endIdx = -1)
        {
            // 배열의 길이가 너무 작으면 오류 메세지 출력
            CheckArrLength(arr.Length);

            // 끝 배열의 인덱스가 배열의 길이보다 크거나 같으면 오류 메세지 출력
            CheckEndIdx(arr.Length, endIdx);

            int start = startIdx;
            int end = endIdx <= start ? arr.Length - 1 : endIdx;

            for (int i = start + 1; i <= end; i++)
            {
                int j = i;
                int temp = arr[i];
                while (j > 0 && sortWay(arr[j - 1], temp))
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = temp;
            }

        }
    }
}
