using System;
using System.Collections;
using System.Collections.Generic;

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
        internal IEnumerable<T> Traverse<T>(Node<T> tree) where T : struct
        {
            q.Enqueue(tree);
            foreach (T node in BFS(tree))
                yield return node;
        }

        private IEnumerable<T> BFS<T>(Node<T> tree) where T : struct
        {
            foreach(var child in tree.Children)
            {
                q.Enqueue(child);
            }
            foreach(var child in tree.Children)
            {
                foreach (var node in BFS(child))
                    yield return node;
            }
            while (q.Count > 0)
            {
                Node<T> node = q.Dequeue() as Node<T>;
                yield return node.Value;
            }
        }
    }
}