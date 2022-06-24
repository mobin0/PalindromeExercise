using System;
using Xunit;

namespace PalindromeExercise.Tests
{
    public class PalindromeExcerciseTests
    {
        //[Fact]
        [Theory]
        [InlineData("yay", true)] // you will need to put some test data and expected result here.  
        [InlineData("mayonaise", false)]
        [InlineData("Charles", false)]
        [InlineData("Malayalam", true)]
        [InlineData("English", false)]
        public void isAPalindromeTest(string input, bool expected)
        {
            WordSmith w = new WordSmith();
            bool actual = w.isAPalindrome(input);
            Assert.Equal(expected, actual);

        }
    }
}
