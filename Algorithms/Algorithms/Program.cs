using Algorithms.Contents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        //aa
        static void Main(string[] args)
        {
            //    List<int> needSort = new List<int>() {
            //    2,5,8,10,9,6,4,3
            //    };
            Sort sort = new Sort();
            //sort.InsertionSort<int>(needSort, (i1, i2) =>
            //{
            //    return i1 < i2;
            //});

            //sort.MergeSort<int>(needSort, 0, needSort.Count - 1, (t1, t2) =>
            //  {
            //      return t1 < t2;
            //  });

            //foreach (var item in needSort)
            //{
            //    Console.WriteLine(item);
            //}

            //List<num> needSort = new List<num>() {
            //   new num() {  Num=10, NumName="10" },
            //   new num() {  Num=8, NumName="8" },
            //   new num() {  Num=9, NumName="9" },
            //   new num() {  Num=3, NumName="3" },
            //   new num() {  Num=6, NumName="6" },
            //   new num() {  Num=2, NumName="2" },
            //   new num() {  Num=1, NumName="1" },
            //   new num() {  Num=7, NumName="7" }
            //};

            //sort.MergeSort<num>(needSort, 0, needSort.Count - 1, (t1, t2) =>
            //  {
            //      return t1.Num < t2.Num;
            //  });

            //foreach (var item in needSort)
            //{
            //    Console.WriteLine(item.NumName);
            //}
            //int[] intArray = { 10, -1, 4, 6, -2, 3 };
            //MaxSubArray sub = new MaxSubArray();
            //var result = sub.FindMaxSubArray(intArray, 0, intArray.Length - 1);

            //Console.WriteLine($"begin:{result.Item1},end:{result.Item2},max:{result.Item3}");

            //var result1 = sub.FindMaxSubArrayByForce(intArray, 0, intArray.Length);
            //Console.WriteLine($"begin:{result1.Item1},end:{result1.Item2},max:{result1.Item3}");

            int[][] leftMatrix = new int[2][];
            leftMatrix[0] = new int[] { 1, 3 };
            leftMatrix[1] = new int[] { 7, 5 };

            int[][] rightMatrix = new int[2][];
            rightMatrix[0] = new int[] { 6, 8 };
            rightMatrix[1] = new int[] { 4, 2 };
            Matrix ma = new Matrix();
            var result = ma.SquareMatrixMultiply(leftMatrix, rightMatrix);
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result[i].Length; j++)
                {
                    Console.Write($"{result[i][j]}\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }

    public class num
    {
        public int Num { get; set; }
        public string NumName { get; set; }
    }
}
