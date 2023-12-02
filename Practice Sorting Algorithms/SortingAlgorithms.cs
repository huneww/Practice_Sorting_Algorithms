using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sorting_Algorithms
{
    public abstract class SortingAlgorithms
    {
        // 정렬 방법 대리자
        public delegate bool SortWay(int x, int y);

        // 로그 출력
        [Conditional("DEBUG")]
        public void Log()
        {
            StackTrace trace = new StackTrace();
            StackFrame? frame = trace.GetFrame(1);
            if (frame != null)
            {
                Console.WriteLine("Method Name : " + frame.GetMethod().Name);
                Console.WriteLine("Line Number : " + frame.GetFileLineNumber());
            }
        }

        // 배열 프린트
        public void PrintAll(int[] arr)
        {
            foreach (var value in arr)
                Console.Write(value + " ");
            Console.WriteLine("\n=====================================");
        }

        // 정렬 추상 메서드
        public abstract void Sorting(int[] arr, SortWay sortWay, int startIdx = 0, int endIdx = -1);
    }
}
