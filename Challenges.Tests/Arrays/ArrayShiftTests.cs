using System;
using CodeChallenges.Arrays;
using Xunit;

namespace Challenges.Tests.arrays
{
   public class ArrayShiftTests
    {
        [Fact(Skip = "skipping so we can focus on challenge 3")]
        public static void Shift_Array_add_num_in_middle_of_array()
        {
            int[] arrayToShift = new[] { 1, 2, 3, 4 };
            int numToInsert = 6;

            int[] result = ArrayShift.insertShiftArray(arrayToShift, numToInsert);

            Assert.Equal(new int[] { 1, 2, 6, 3, 4 }, result);
        }
    }
}
