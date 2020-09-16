﻿using Xunit;


namespace Challenges.test.Arrays
{
    public class Search
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, 2, 1)]
        [InlineData(new[] { 4, 8, 15, 16, 23, 42 }, 15, 2)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, 6, 5)]
        [InlineData(new[] { 11, 22, 33, 44, 55, 66, 77 }, 90, -1)]
        [InlineData(new[] { 1 }, 1, 0)]

        public void BiSearch(int[] testArray, int testN, int expected)
        {
            // Arrange
            //InlineData

            //Act
            int result = BiSearch(testArray, testN);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
