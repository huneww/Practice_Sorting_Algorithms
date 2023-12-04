using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sorting_Algorithms
{
    internal class QuickSort : SortingAlgorithms
    {
        public new void Sorting(int[] arr, int startIdx, int endIdx)
        {
            Sorting(arr, (x, y) => { return x > y; }, startIdx, endIdx);
        }

        public new void Sorting(int[] arr, SortWay sortWay, int startIdx, int endIdx)
        {
            // 배열의 길이가 너무 작으면 오류 메세지 출력
            CheckArrLength(arr.Length);

            // 끝 배열의 인덱스가 배열의 길이보다 크거나 같으면 오류 메세지 출력
            CheckEndIdx(arr.Length, endIdx);

            // 시작 지점이 끝지점보다 작을때만
            if (startIdx < endIdx)
            {
                // 피벗의 인덱스값 획득
                int pivot = Partition(arr, sortWay, startIdx, endIdx);

                // 피벗을 제외한 앞, 뒤로 정렬 메서드 호출
                Sorting(arr, sortWay, startIdx, pivot - 1);
                Sorting(arr, sortWay, pivot + 1, endIdx);
            }

        }

        private int Partition(int[] arr, SortWay sortWay, int startIdx, int endIdx)
        {
            // 현재 범위의 피벗값
            int pivot = arr[endIdx];
            // 피벗값 보다 작은 값, 큰 값의 인덱스 위치
            int i = startIdx - 1;

            for (int j = startIdx; j <= endIdx; j++)
            {
                // 정렬 방법에 맞다면
                if (sortWay(pivot, arr[j]))
                {
                    // 인덱스 위치 변경
                    i++;

                    // i의 값과 j의 값을 교환
                    // 오름차순이라면 j의 값이 pivot보다 작아서
                    // i번쨰로 값을 이동
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // 피벗의 값을 i의 앞으로 이동
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[endIdx];
            arr[endIdx] = temp2;

            // 피벗의 인덱스 번호 반환
            return i + 1;
        }

    }
}
