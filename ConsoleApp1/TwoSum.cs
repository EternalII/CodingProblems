using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://leetcode.com/problems/two-sum/description/

/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.
 */

namespace ConsoleApp1
{
    internal class TwoSum
    {
        public TwoSum() {
            int[] result;

            Console.WriteLine("Choose case: 1. CaseA, 2. CaseB");
            string getCase = Console.ReadLine();
            (int[] nums, int target) = (new int[0],0); // switch to caseA(), caseB() or caseC()

            switch (getCase)
            {
                case "1":
                    (nums, target) = caseA();
                    break;
                case "2":
                    (nums, target) = caseB();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to CaseA.");
                    (nums, target) = caseA();
                    break;
            }

            result = addsToTarget(nums, target);

            Console.WriteLine($"Calculated result: [{result[0]},{result[1]}]");
        }

        internal (int[], int) caseA()
        {
            int[] nums = { 2, 7, 11, 15 };
            int result = 9;
            Console.WriteLine( "Expected result: [0,1] ");
            return (nums, result);
        }

        internal (int[], int) caseB()
        {
            int[] nums = { 3, 2, 4 };
            int result = 6;
            Console.WriteLine("Expected result: [1,2] ");
            return (nums, result);
        }


        internal int[] addsToTarget(int[] nums, int target)
        {
            int[] result = { 0, 0 };

            for (int i=0; i < nums.Length; i++)
            {
                for (int j=1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }

            }
            return result;
        }
    }
}
