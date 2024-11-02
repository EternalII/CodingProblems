using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
https://leetcode.com/problems/longest-palindromic-substring/description/

Given a string s, return the longest palindromic substring in s.
Palindrome: a word, phrase, or sequence that reads the same backward as forward, e.g., 'madam' or 'taco cat'.
*/

namespace ConsoleApp1
{
    internal class LongPaliSub
    {
        public LongPaliSub() 
        {
            Console.WriteLine("Write a word, preferibly with a palindrome hidden within!");
            string word = Console.ReadLine();
            string palindrome = findPalindrome(word);
            if (palindrome != null)
                Console.Write($"The palindrome found is: {palindrome}");
            else
                Console.WriteLine("No palindrome found");
        }

        string findPalindrome(string word)
        {
            int left=0, right=word.Length-1;
            bool isPali = false;
            string paliWord = null;

            while (left < word.Length || isPali == true) // progress left
            {
                while (left < right) // retreat right, until it hits left
                {
                    if (word[right] == word[left])
                        isPali = checkLetters(word,left,right);
                    right--;
                }
                if (isPali == true)
                    break;
                left++;
                right = word.Length - 1;
            }
            if (isPali)
                paliWord = word.Substring(left, right - left);
            return paliWord;
        }

        bool checkLetters(string word, int left, int right) // returns false is fails palindrome check
        {
            if (left >= right)
            { 
            }
            if (word[left] == word[right])
                checkLetters(word, left+1, right-1);

            return false;
        }
    }
}
