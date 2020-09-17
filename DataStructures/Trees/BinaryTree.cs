using DataStructures.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    class BinaryTree<T>
    {
        Node<T> Root { get; set; }
        IEnumerable<T> PreOrder(StringBuilder sb, Node node)
        {
            if (node != null)
            {
                sb.Append(node.Value);
                sb.Append(" ");
                PreOrder(sb, node.Left);
                PreOrder(sb, node.Right);
            }
            T result = (T)GetEnumerator();

            yield return result;
        }
        IEnumerable<T> InOrder(StringBuilder sb, Node node)
        {
            if (node != null)
            {
                InOrder(sb, node.Left);
                sb.Append(node.Value);
                sb.Append(" ");
                InOrder(sb, node.Right);
            }

            T result = (T)GetEnumerator();

            yield return result;
        }


        IEnumerable<T> PostOrder(StringBuilder sb, Node node)
        {
            if (node != null)
            {
                PostOrder(sb, node.Left);
                PostOrder(sb, node.Right);
                sb.Append(node.Value);
                sb.Append(" ");
            }

            T result = (T)GetEnumerator();

            yield return result;
        }

        private IEnumerable<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
