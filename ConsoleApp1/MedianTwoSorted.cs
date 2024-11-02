using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/median-of-two-sorted-arrays/description/

/*
 * Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
 *
 * The overall run time complexity should be O(log (m+n)).
 */

/* 
 * This code does not fullfill the complexity requirement because of Concat (O(m+n)) and Sort (O(m+n(log(M+N)))
*/

namespace ConsoleApp1
{
    internal class MedianTwoSorted
    {
        public MedianTwoSorted() {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };

            findMedian(nums1, nums2);
        }   

        internal void findMedian(int[] nums1, int[] nums2)
        {
            int[] combinedArr = nums1.Concat(nums2).ToArray();
            Array.Sort(combinedArr);
            int arrLength = combinedArr.Length;
            float result;

            Console.Write("[");
            foreach (int item in combinedArr)
            {
                Console.Write(item);
            }
            Console.WriteLine("]");

            if (arrLength == 0)
                Console.WriteLine("Lacking array elements");
            if (arrLength%2 == 0) 
            {
                result = (combinedArr[arrLength / 2 - 1] + combinedArr[arrLength / 2]);
                result = result / 2;
                Console.WriteLine($"Median = ({combinedArr[arrLength / 2 - 1]} + {combinedArr[arrLength / 2]})/2 = {result}");
            }
            else
            {
                result = combinedArr[arrLength / 2];
                Console.WriteLine($"Median = {result}");
            }

            
        }
    }
}
