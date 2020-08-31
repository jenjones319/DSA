using Challenges401.Arrays;
using Xunit;

namespace Challenges.Test
{
    public class ReverseTest
    {
        [Fact]
        public void can_Reverse_Array()
        {
            //Arrange
            int[] testArray = new[] { 1, 2, 3 };

            //Act
            int[] result = Reverse.ReverseArray(testArray);

            //Assert
            Assert.Equal(new[] { 3, 2, 1 }, result);
        }
    }
}
