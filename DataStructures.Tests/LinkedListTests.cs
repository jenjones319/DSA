using DataStructures.LinkedLists;
using Xunit;

namespace DataStructures.Tests.LinkedLists
{
    public class LinkedListTests
    {
        [Fact]
        public void Insert_adds_value_to_start()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            list.Insert(1);

            // Assert
            Assert.Equal("{ 1 } -> NULL", list.ToString());

        }
        [Theory]
        [InlineData(1, true)]
        [InlineData(3, true)]
        [InlineData(5, false)]
        public void Includes_True_False(int val, bool expect)
        {
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);

            Assert.Equal(expect, list.Includes(val));

        }

    }
}
