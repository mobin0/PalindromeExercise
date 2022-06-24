using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool isAPalindrome(string s)
        {
            s = s.ToLower();
            string reverse = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse += s[i];
            }
            return reverse == s;
        }
    }
}
