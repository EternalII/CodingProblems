using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
