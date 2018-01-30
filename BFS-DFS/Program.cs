using System;
using System.Linq;

namespace BFS_DFS
{
    class Program
    {
        private static Node<int> tree;

        static void Main(string[] args)
        {
            tree = new Node<int>(1);

            var firstChildren = new[] { new Node<int>(2), new Node<int>(3) };
            var secondChildren = new[] { new Node<int>(4), new Node<int>(5), new Node<int>(6) };

            tree.AddChild(firstChildren[0]);
            tree.AddChild(firstChildren[1]);

            tree.Children.First().AddChild(secondChildren[0]);
            tree.Children.First().AddChild(secondChildren[1]);
            tree.Children.First().AddChild(secondChildren[2]);

            Console.WriteLine($"Traversing using {nameof(BreadthFirstTraverser)}...");        
            new BreadthFirstTraverser().Traverse(tree);
            Console.WriteLine();
            Console.WriteLine($"Traversing using {nameof(DepthFirstTraverser)}...");
            new DepthFirstTraverser().Traverse(tree);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
