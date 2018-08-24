using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Contents
{
    public class Sort
    {
        /// <summary>
        /// 插入排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="action"></param>
        public void InsertionSort<T>(List<T> data, Func<T, T, bool> action)
        {
            for (int i = 1; i < data.Count(); i++)
            {
                T currentData = data[i];
                int j = i - 1;
                while (j >= 0 && action(currentData, data[j]))
                {
                    data[j + 1] = data[j];
                    j--;
                }
                data[j + 1] = currentData;               
            }
        }

        /// <summary>
        /// 归并排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="p"></param>
        /// <param name="r"></param>
        public void MergeSort<T>(List<T> data, int p, int r, Func<T, T, bool> func)
        {
            if (p < r)
            {
                var midnum = (p + r) / 2;
                MergeSort(data, p, midnum, func);
                MergeSort(data, midnum + 1, r, func);
                Merge(data, p, midnum, r, func);
            }
        }

        private void Merge<T>(List<T> data, int p, int midnum, int r, Func<T, T, bool> func)
        {
            var left = new List<T>();
            var right = new List<T>();
            for (int i = p; i <= r; i++)
            {
                if (i <= midnum)
                {
                    left.Add(data[i]);
                }
                else
                {
                    right.Add(data[i]);
                }
            }
            int leftNum = 0;
            int rightNum = 0;
            int now = 0;
            while (leftNum < left.Count || rightNum < right.Count)
            {
                if (leftNum < left.Count && rightNum < right.Count)
                {
                    //left[leftNum] < right[rightNum]  正序
                    if (func(left[leftNum], right[rightNum]))
                    {
                        data[p + now++] = left[leftNum++];
                    }
                    else
                    {
                        data[p + now++] = right[rightNum++];
                    }
                }
                else if (leftNum < left.Count && rightNum >= right.Count)
                {
                    data[p + now++] = left[leftNum++];
                }
                else if (leftNum >= left.Count && rightNum < right.Count)
                {
                    data[p + now++] = right[rightNum++];
                }
            }
        }
    }
}
