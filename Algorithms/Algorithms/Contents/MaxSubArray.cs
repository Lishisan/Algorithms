using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Contents
{
    public class MaxSubArray
    {
        /// <summary>
        /// 暴力求解
        /// </summary>
        /// <param name="array"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public Tuple<int, int, int> FindMaxSubArrayByForce(int[] array, int begin, int end)
        {
            var maxSum = array[0];
            var maxLeft = begin;
            var maxRight = begin;
            for (int i = begin; i < end; i++)
            {
                var iMaxSum = 0;
                for (int j = i; j < end; j++)
                {
                    iMaxSum += array[j];
                    if (iMaxSum > maxSum)
                    {
                        maxSum = iMaxSum;
                        maxLeft = i;
                        maxRight = j;
                    }
                }
            }
            return new Tuple<int, int, int>(maxLeft, maxRight, maxSum);
        }


        /// <summary>
        /// 递归求解
        /// </summary>
        /// <param name="array"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public Tuple<int, int, int> FindMaxSubArray(int[] array, int begin, int end)
        {
            if (begin == end)
            {
                return new Tuple<int, int, int>(begin, end, array[begin]);
            }
            var midnum = (begin + end) / 2;
            var leftMax = FindMaxSubArray(array, begin, midnum);
            var rightMax = FindMaxSubArray(array, midnum + 1, end);
            var midMax = FindCrossSubArray(array, begin, end, midnum);
            var left = leftMax.Item3;
            var right = rightMax.Item3;
            var mid = midMax.Item3;
            var max = left>right?left:right;
            max = max > mid ? max : mid;
            if (left == max)
                return leftMax;
            else if (right == max)
                return rightMax;
            else
                return midMax; 
        }

        /// <summary>
        /// 线性求解
        /// </summary>
        /// <param name="array"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public Tuple<int, int, int> FindMaxSubArrayByLinear(int[] array, int begin, int end)
        {
            int maxSum = array[begin];
            int boundary = array[begin];
            int left = begin;
            int right = begin;
            int currentleft = begin;
            for (int i = begin + 1; i < end; i++)
            {
                if (boundary + array[i] >= array[i])
                {
                    boundary += array[i];
                }
                else
                {
                    boundary = array[i];
                    currentleft = i;
                }
                if (boundary > maxSum)
                {
                    maxSum = boundary;
                    right = i;
                    left = currentleft;
                }
            }
            return new Tuple<int, int, int>(left, right, maxSum);
        }


        private Tuple<int, int, int> FindCrossSubArray(int[] array, int begin, int end, int midnum)
        {
            if (begin == end)
            {
                return new Tuple<int, int, int>(begin, end, array[begin]);
            }
            var leftnum = midnum;
            var rightnum = midnum;
            var maxSum = 0;
            var curSum = 0;
            for (int i = midnum; i >= begin; i--)
            {
                curSum += array[i];
                if (curSum > maxSum)
                {
                    maxSum = curSum;
                    leftnum = i;
                }
            }
            curSum = maxSum;
            for (int i = midnum + 1; i <= end; i++)
            {
                curSum += array[i];
                if (curSum > maxSum)
                {
                    maxSum = curSum;
                    rightnum = i;
                }
            }
            return new Tuple<int, int, int>(leftnum, rightnum, maxSum);
        }
    }
}
