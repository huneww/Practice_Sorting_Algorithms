using System;


namespace Practice_Sorting_Algorithms
{
    public class BubbleSort : SortingAlgorithms
    {

        // 정렬 방식을 지정하지 안는 메서드
        [Obsolete("This meathd is BubbleSort, Time Complexity is O(n^2)")]
        public new void Sorting(int[] arr, int startIdx = 0, int endIdx = -1)
        {
            // 기본적으로 오름차순으로 정렬
            Sorting(arr, (x, y) => { return x > y; }, startIdx, endIdx);
        }

        // 뭐야 컴파일 오류 메시지 돌려줘
        // 이렇게 하면 된다며
        // 애트리뷰트는 상속할수 없기 때문에
        // 오버라이드한 메서드의 애트리뷰트는 호출하는 곳에서 메시지를 내보니지 않음

        // 정렬 메서드
        [Obsolete("This meathd is BubbleSort, Time Complexity is O(n^2)")]
        public new void Sorting(int[] arr, SortWay sortWay, int startIdx = 0, int endIdx = -1)
        {
            // 배열의 길이가 너무 작으면 오류 메세지 출력
            CheckArrLength(arr.Length);

            // 끝 배열의 인덱스가 배열의 길이보다 크거나 같으면 오류 메세지 출력
            CheckEndIdx(arr.Length, endIdx);

            int start = startIdx;
            // endIdx값이 있다면 endIdx값을 저장
            // endIdx갑이 없다면 배열의 길이 저장
            int end = endIdx <= startIdx ? arr.Length - 1 : endIdx;

            int temp = 0;

            for (int i = start; i < end; i++)
            {
                for (int j = start; j < end - i; j++)
                {
                    if (sortWay(arr[j], arr[j + 1]))
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Log();
        }
    }
}
