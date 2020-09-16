using System;
using System.Collections.Generic;
using System.Text;


namespace DataStructures.Trees
{
    public class BinarySearchTree
    {

        public Node Root { get; set; }

        public void Add(int value)
        {
            Node newNode = new Node(value);

            if (Root == null)
                Root = newNode;

            else
            {
                Node current = Root;
                Node Prev;
                while (true)
                {
                    Prev = current;

                    if (value < current.Value)
                    {
                        current = current.Left;

                        if (current == null)
                        {
                            Prev.Left = newNode;
                            return;
                        }
                    }

                    else
                    {
                        current = current.Right;

                        if (current == null)
                        {
                            Prev.Right = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public bool Contains(Node current, int value)
        {
            if (Root == null || current == null)
                return false;

            else
            {
                if (current.Value == value)
                    return true;

                else if (value < current.Value)
                    return Contains(current.Left, value);

                else
                    return Contains(current.Right, value);
            }
        }

        public string PreOrder(StringBuilder sb, Node node)
        {
            if (node != null)
            {
                sb.Append(node.Value);
                sb.Append(" ");
                PreOrder(sb, node.Left);
                PreOrder(sb, node.Right);
            }
            string result = sb.ToString();

            return result.Remove(result.Length - 1, 1);
        }

        public string InOrder(StringBuilder sb, Node node)
        {
            if (node != null)
            {
                InOrder(sb, node.Left);
                sb.Append(node.Value);
                sb.Append(" ");
                InOrder(sb, node.Right);
            }

            string result = sb.ToString();

            return result.Remove(result.Length - 1, 1);
        }

        public string PostOrder(StringBuilder sb, Node node)
        {
            if (node != null)
            {
                PostOrder(sb, node.Left);
                PostOrder(sb, node.Right);
                sb.Append(node.Value);
                sb.Append(" ");
            }

            string result = sb.ToString();

            return result.Remove(result.Length - 1, 1);
        }

        public string BreadthFirst()
        {
            Queue<Node> queue = new Queue<Node>();
            Node root = Root;
            queue.Enqueue(root);

            List<int> list = new List<int>();
            bool didThrow = false;

            while (didThrow == false)
            {
                Node temp = queue.Dequeue();
                list.Add(temp.Value);

                if (temp.Left != null)
                    queue.Enqueue(temp.Left);

                if (temp.Right != null)
                    queue.Enqueue(temp.Right);

                try
                {
                    queue.Peek();
                }
                catch
                {
                    didThrow = true;
                }
            }
            return String.Join(",", list);
        }
    }
}
