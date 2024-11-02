using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Questions from https://leetcode.com/discuss/interview-question/488887/amazon-final-interview-questions-sde1

namespace ConsoleApp1
{
    internal class Program
    {   
        static void Main(string[] args) // Note to self: Prettify exit clause so it won't depend on menu return
        {
            bool exit = false;
            while (exit == false)
            {
                
                exit = Menu();
                pressToContinue();
                Console.Clear();
            }
        }

        static bool Menu()
        {
            
            dynamic option;
            int key = 1; // habds a key to each topic
            // topics stores all question titles in an array
            string[] topics = { "Two Sum", "Median of Two Sorted Arrays", "Longest Palindromic Substring" }; 
            Dictionary<int, string> questions = new Dictionary<int, string>();

            foreach (string topic in topics) // sets up mapping according to key and topic
            {
                questions[key] = topic;
                key++;
            }
            Console.WriteLine("Here's a list of available questions:");
            foreach (var item in questions)
            {
                Console.WriteLine($"{item.Key}.{item.Value}");
            }

            Console.WriteLine("To quit, select 0. Choose a question:");
            option = Console.ReadLine();
            
            switch (option)
            {
                case "0":
                    return true;
                case "1":
                    TwoSum twoSum = new TwoSum();
                    break;
                case "2":
                    MedianTwoSorted median = new MedianTwoSorted();
                    break;
                case "3":
                    LongPaliSub pali = new LongPaliSub();
                    break;
                default:
                    Menu();
                    break;
            }
            return false;
        }

        static void pressToContinue()
        {
            Console.WriteLine("Press any key to contninue...");
            Console.ReadLine();
        }
    }
}
