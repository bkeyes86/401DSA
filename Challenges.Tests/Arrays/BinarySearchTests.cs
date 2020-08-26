using System;
using Xunit;
using CodeChallenges.Arrays;

namespace Challenges.test.Arrays
{
    public class BinarySearchTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 4, 5 }, 3, -1)]
        [InlineData(new int[] { 1, 3, 5, 18, 22 }, 3, 1)]
        [InlineData(new int[] {1, 2, 3, 4, 5, 6, 7 }, 5, 4)]
        public void TestBinarySearch(int[] array, int searchKey, int expected)
    {
        int result = BinarySearch.Search(array, searchKey);
        Assert.Equal(expected, result);



    }
}
}
