using System.Collections;
using System.Collections.Generic;

namespace BFS_DFS
{
    internal class Node<T> where T : struct
    {
        public readonly T Value;
        public ICollection<Node<T>> Children { get; } = new List<Node<T>>();
        public Node(T value)
        {
            Value = value;
        }

        public void AddChild(Node<T> child)
        {
            Children.Add(child);
        }
    }
}