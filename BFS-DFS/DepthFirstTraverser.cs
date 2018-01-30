using System;

namespace BFS_DFS
{
    internal class DepthFirstTraverser
    {
        public DepthFirstTraverser()
        {
        }

        // should write out 1, 2, 4, 5, 6, 3
        internal void Traverse<T>(Node<T> tree) where T : struct
        {
            Console.WriteLine(tree.Value);
            foreach (var child in tree.Children)
            {
                Traverse(child);
            }
        }
    }
}