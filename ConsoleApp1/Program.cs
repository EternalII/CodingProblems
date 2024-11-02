using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Questions from https://leetcode.com/discuss/interview-question/488887/amazon-final-interview-questions-sde1

namespace ConsoleApp1
{
    internal class Program
    {   
        static void Main(string[] args)
        {


            Menu();
        }

        static void Menu()
        {
            
            dynamic option;
            int key = 1;
            string[] topics = { "Two Sum", "Median of Two Sorted Arrays" };
            Dictionary<int, string> questions = new Dictionary<int, string>();

            foreach (string topic in topics)
            {
                questions[key] = topic;
                key++;
            }

            Console.WriteLine("Here's a list of available questions:");
            foreach (var item in questions)
            {
                Console.WriteLine($"{item.Key}.{item.Value}");
            }

            Console.WriteLine("Choose a question:");
            option = Console.ReadLine();
            
            switch (option)
            {
                case "1":
                    TwoSum twoSum = new TwoSum();
                    break;
                 case "2":
                    MedianTwoSorted median = new MedianTwoSorted();
                    break;

                default:
                    break;
            }
        }
    }
}
