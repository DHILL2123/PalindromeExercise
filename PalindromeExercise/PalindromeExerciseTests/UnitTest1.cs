using System;
using PalindromeExercise;
using Xunit;


namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("wow", true)]
        [InlineData("level", true)]// ← you will need to put some test data and expected result here.
        public void MyTest(string word, bool expected)
        {

            //arrange
            var tester = new WordSmith();

            //act
            bool actual = tester.IsAPalindrome(word);

            //assert
            Assert.Equal(expected, actual);
        }


    }
}
