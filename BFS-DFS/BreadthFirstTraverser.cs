using System;
using System.Collections;

namespace BFS_DFS
{
    internal class BreadthFirstTraverser
    {
        public BreadthFirstTraverser()
        {
            q = new Queue();
        }

        private Queue q;

        // should write out 1, 2, 3, 4, 5, 6
        internal void Traverse<T>(Node<T> tree) where T : struct
        {
            q.Enqueue(tree);
            BFS(tree);
        }

        private void BFS<T>(Node<T> tree) where T : struct
        {
            foreach(var child in tree.Children)
            {
                q.Enqueue(child);
            }
            foreach(var child in tree.Children)
            {
                BFS(child);
            }
            while (q.Count > 0)
            {
                Node<T> node = q.Dequeue() as Node<T>;
                Console.WriteLine(node.Value);
            }
        }
    }
}