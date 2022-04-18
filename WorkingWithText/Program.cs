using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace WorkingWithText
{
    public static class WorkingWithText
    {
        // 1- Write a method that accepts a few numbers separated by a hyphen. Check
        // to see if there are duplicates. If so, return bool True; otherwise, return bool False.
        public static bool AreThereDuplicates(string hyphenNum)
        {

            string[] nums = hyphenNum.Split('-', StringSplitOptions.RemoveEmptyEntries);
            if (nums.Count() != nums.Distinct().Count())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 2- Write a method that accepts a string of numbers separated by a hyphen. If the input 
        // is NOT in the correct format OR is NOT consecutive then return bool False. If the format 
        // is correct AND the numbers are consecutive, return bool True. For
        // example, if the input is "5-6-7-8-9" or "20-19-18-17-16", return bool True.
        // Do not use .Sort, it will cause the test to pass when it actually does not.
        public static bool IsConsecutive(string hyphenNum)
        {
            string[] nums = hyphenNum.Split('-');
            int intTest = 0;
            
            bool bolGood = true;

            
            
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if(int.TryParse(nums[i], out intTest) == false || int.TryParse(nums[i + 1], out intTest) == false)
                {
                    bolGood = false;
                    break;
                }
                if (Convert.ToInt32(nums[i]) - Convert.ToInt32(nums[i + 1]) != 1 && Convert.ToInt32(nums[i]) - Convert.ToInt32(nums[i + 1]) != -1)
                {
                    bolGood = false;
                }
            }

            return bolGood;

        }

        // 3- Write a method that accepts a string of a time 24-hour time format
        // (e.g. "09:00"). A valid time should be between 00:00 and 23:59. If the time is valid,
        // return a bool True; otherwise, return a bool False. If the user doesn't provide any values,
        // consider it as False. Make sure that its returns false if any letters are passed.
        public static bool IsValidTime(string hyphenNum)
        {
            string[] times;
            int hour;
            int minute;
            bool bolValid;
            if (string.IsNullOrEmpty(hyphenNum) == false && hyphenNum[2] == ':')
            {
                times = hyphenNum.Split(':');
                if (int.TryParse(times[0], out hour) == false || times.Length > 2)
                {
                    bolValid = false;
                }
                else if (int.TryParse(times[1], out minute) == false)
                {
                    bolValid = false;
                }
                else if (hour < 0 || hour > 23 || minute < 0 || minute > 59)
                {
                    bolValid = false;
                }
                else
                {
                    bolValid = true;
                }
            }
            else
            {
                bolValid = false;
            }
            return bolValid;
        }


        // 4- Write a method that accepts a string of a few words separated by a space. Use the
        // words to create a variable name with PascalCase. For example, if the user types: "number
        // of students", return "NumberOfStudents". Make sure that the program is not dependent on
        // the input. So, if the user types "NUMBER OF STUDENTS", the program should still return "NumberOfStudents".
        // Trim off unneeded spaces.
        public static string PascalConverter(string aFewWords)
        {
            string[] words;
            if (!String.IsNullOrEmpty(aFewWords))
            {
                words = aFewWords.Trim().Split(' ');

                string final = "";

                foreach (string s in words)
                {
                    final += s[0].ToString().ToUpper() + s.Substring(1).ToLower();
                }
                return final.Trim();
            }
            return "";

        }

        // 5- Write a method that accepts an English word. Count the number of vowels
        // (a, e, i, o, u) in the word. So, if the user enters "inadequate", the program should
        // return 6.
        public static int VowelCounter(string aWord)
        {
            string[] vowels = { "a", "e", "i", "o", "u" };
            int totalVowels = 0;
            foreach (char c in aWord)
            {
                if (vowels.Contains(c.ToString().ToLower()))
                {
                    totalVowels += 1;
                }
            }
            return totalVowels;
        }
    }


    internal static class Program
    {
        private static void Main()
        {
            // Method intentionally left empty.
        }
    }
}
