using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sorting_Algorithms
{
    internal class SelectionSort : SortingAlgorithms
    {
        // 정렬 방식을 지정하지 안는 메서드
        [Obsolete("This meathd is SelectionSort, Time Complexity is O(n^2)")]
        public new void Sorting(int[] arr, int startIdx = 0, int endIdx = - 1)
        {
            // 기본적으로 오름차순으로 정렬
            Sorting(arr, (x, y) => { return x > y; }, startIdx, endIdx);
        }

        // 정렬 메서드
        [Obsolete("This meathd is SelectionSor, Time complexity is O(n^2)")]
        public new void Sorting(int[] arr, SortWay sortWay, int startIdx = 0, int endIdx = -1)
        {
            // 배열의 길이가 너무 작으면 오류 메세지 출력
            CheckArrLength(arr.Length);

            // 끝 배열의 인덱스가 배열의 길이보다 크거나 같으면 오류 메세지 출력
            CheckEndIdx(arr.Length, endIdx);

            int start = startIdx;
            int end = endIdx <= startIdx ? arr.Length - 1 : endIdx;

            int temp = 0;
            // 배열의 최대값 저장 변수
            int max = 0;

            for (int i = start; i <= end; i++)
            {
                // 반복문 시작시  정렬의 시작지점으로 초기화
                max = start;
                for (int j = start; j <= end - i; j++)
                {
                    if (sortWay(arr[j], arr[max]))
                    {
                        max = j;
                    }
                }
                
                temp = arr[max];
                arr[max] = arr[end - i];
                arr[end - i] = temp;
            }

        }

    }   
}
