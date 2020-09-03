using DataStructures.LinkedLists;

namespace Challenges401.LLzip
{
    public class LLZip
    {
        public static LinkedList Zip(LinkedList listA, LinkedList listB)
        {
            Node currentA = listA.Head;
            Node currentB = listB.Head;

            LinkedList result = new LinkedList();

            while (currentA != null || currentB != null)
            {
                if (currentA != null)
                {
                    result.Append(currentA.Value);
                    currentA = currentA.Next;
                }
                if (currentB != null)
                {
                    result.Append(currentB.Value);
                    currentB = currentB.Next;
                }
            }
            return result;
        }
    }

}
