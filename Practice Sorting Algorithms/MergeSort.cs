using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sorting_Algorithms
{
    internal class MergeSort : SortingAlgorithms
    {
        public new void Sorting(int[] arr, int startIdx, int endIdx)
        {
            Sorting(arr, (x, y) => { return x > y; }, startIdx, endIdx);
        }

        public new void Sorting(int[] arr, SortWay sortWay, int startIdx, int endIdx)
        {
            // 배열 길이 확인
            CheckArrLength(arr.Length);

            // 맨끝 인덱스 확인
            CheckEndIdx(arr.Length, endIdx);

            if (startIdx < endIdx)
            {
                // 중간 인덱스 확인
                int mid = (startIdx + endIdx) / 2;
                // 앞, 뒤 분열
                Sorting(arr, sortWay, startIdx, mid);
                Sorting(arr, sortWay, mid + 1, endIdx);
                // 앞, 뒤 정렬
                Merge(arr, sortWay, startIdx, mid, endIdx);
            }
        }

        private void Merge(int[] arr, SortWay sortWay, int start, int mid, int end)
        {
            // 정렬한 값 임시 저장
            int[] temp = new int[arr.Length];
            // 앞부분 배열 인덱스
            int i = start;
            // 뒷부분 배열 인덱스
            int j = mid + 1;
            // 임시 저장 배열 인덱스
            int k = start;

            while (i <= mid && j <= end)
            {
                // 정렬 방법에 맞게 temp에 값 저장
                if (sortWay(arr[j], arr[i]))
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];
                }
            }

            // 앞부분이 남아있다면
            // 앞부분을 순차적으로 temp에 저장
            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }

            // 뒷부분이 남아있다면
            // 뒷부분을 순차적으로 temp에 저장
            while (j <= end)
            {
                temp[k++] = arr[j++];
            }

            // 정렬한 배열 값 지정
            for (i = start; i <= end; i++)
            {
                arr[i] = temp[i];
            }
        }

    }
}
