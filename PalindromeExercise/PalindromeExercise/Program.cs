using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            WordSmith w = new WordSmith();

            Console.WriteLine(w.isAPalindrome("Malayalam"));
        }
    }
}
