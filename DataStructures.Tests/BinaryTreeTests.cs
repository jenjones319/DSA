using DataStructures.Trees;
using System.Text;
using Xunit;

namespace DataStructures.Tests
{
    public class TreeTests
    {
        [Fact]
        public void Add_value_to_empty_tree()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();

            // Act
            tree.Add(4);

            //Assert
            Assert.Equal(4, tree.Root.Value);
        }

        [Fact]
        public void Add_one_Left_and_one_Right_node()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();

            // Act
            tree.Add(8);
            tree.Add(4);
            tree.Add(5);

            //Assert
            Assert.Equal(8, tree.Root.Value);
            Assert.Equal(4, tree.Root.Left.Value);
            Assert.Equal(5, tree.Root.Right.Value);
        }

        [Fact]
        public void Contains_a_value_to_find_Node()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(8);
            tree.Add(4);
            tree.Add(5);
            tree.Add(1);
            tree.Add(6);
            tree.Add(3);

            // Act
            bool trueResult = tree.Contains(tree.Root, 8);
            bool falseResult = tree.Contains(tree.Root, 15);

            //Assert
            Assert.True(trueResult);
            Assert.False(falseResult);
        }

        [Fact]
        public void PreOrder_returns_strings()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(8);
            tree.Add(4);
            tree.Add(5);
            tree.Add(1);
            tree.Add(6);
            tree.Add(3);

            StringBuilder sb = new StringBuilder();

            // Act
            string result = tree.PreOrder(sb, tree.Root);

            //Assert
            Assert.Equal("8 4 5 1 6 3", result);
        }

        [Fact]
        public void InOrder_returns__strings()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(8);
            tree.Add(4);
            tree.Add(5);
            tree.Add(1);
            tree.Add(6);
            tree.Add(3);
            tree.Add(11);
            tree.Add(10);


            StringBuilder sb = new StringBuilder();
            sb.Append(" ");

            // Act
            string result = tree.InOrder(sb, tree.Root);

            //Assert
            Assert.Equal("1 3 5 6 8 10 11", result.Remove(0, 1));
        }

        [Fact]
        public void PostOrder_returns_strings()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(8);
            tree.Add(4);
            tree.Add(5);
            tree.Add(1);
            tree.Add(6);
            tree.Add(3);
            tree.Add(7);


            StringBuilder sb = new StringBuilder();
            sb.Append(" ");
            string result = tree.PostOrder(sb, tree.Root);

            Assert.Equal("1 3 4 8 5 7 6", result.Remove(0, 1));
        }
    }
}
