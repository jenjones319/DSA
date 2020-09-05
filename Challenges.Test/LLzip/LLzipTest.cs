using Challenges401.LLzip;
using DataStructures.LinkedLists;
using Xunit;

namespace Challenges.Test.LLzipTest
{
    public class LLzipTest
    {
        [Fact]
        public void LinkedList_zip_lists_together()
        {
            LinkedList listA = new LinkedList();
            LinkedList listB = new LinkedList();

            listA.Append(1);
            listA.Append(3);
            listA.Append(5);

            listB.Append(2);
            listB.Append(4);
            listB.Append(6);

            LinkedList expected = new LinkedList();

            expected.Append(1);
            expected.Append(2);
            expected.Append(3);
            expected.Append(4);
            expected.Append(5);
            expected.Append(6);

            LinkedList result = LLZip.Zip(listA, listB);

            Assert.Equal(expected.ToString(), result.ToString());
        }

        [Fact]
        public void LinkedList_zip_two_different_sized_list()
        {
            LinkedList listA = new LinkedList();
            LinkedList listB = new LinkedList();


            listA.Append(1);

            listB.Append(2);
            listB.Append(3);
            listB.Append(4);

            LinkedList expected = new LinkedList();


            expected.Append(1);
            expected.Append(2);
            expected.Append(3);
            expected.Append(4);

            LinkedList result = LLZip.Zip(listA, listB);

            Assert.Equal(expected.ToString(), result.ToString());
        }
    }
}
