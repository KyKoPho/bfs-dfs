using System;
using System.Collections.Generic;

namespace BFS_DFS
{
    internal class DepthFirstTraverser
    {
        public DepthFirstTraverser()
        {
        }

        // should write out 1, 2, 4, 5, 6, 3
        internal IEnumerable<T> Traverse<T>(Node<T> tree) where T : struct
        {
            yield return tree.Value;
            foreach (var child in tree.Children)
            {
                foreach (var node in Traverse(child))
                    yield return node;
            }
        }
    }
}