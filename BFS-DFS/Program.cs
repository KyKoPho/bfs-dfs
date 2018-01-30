using System;
using System.Collections.Generic;
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
            var thirdChildren = new[] { new Node<int>(7), new Node<int>(8), new Node<int>(9), new Node<int>(10) };

            tree.AddChild(firstChildren[0]);
            tree.AddChild(firstChildren[1]);

            tree.Children.First().AddChild(secondChildren[0]);
            tree.Children.First().AddChild(secondChildren[1]);
            tree.Children.First().AddChild(secondChildren[2]);

            tree.Children.Skip(1).Take(1).First().AddChild(thirdChildren[0]);
            tree.Children.Skip(1).Take(1).First().AddChild(thirdChildren[1]);
            tree.Children.Skip(1).Take(1).First().AddChild(thirdChildren[2]);
            tree.Children.Skip(1).Take(1).First().AddChild(thirdChildren[3]);

            /* tree looks like
             * 
             * 1 - 2 - 4
             *       - 5
             *       - 6        
             *   - 3 - 7
             *       - 8
             *       - 9
             *       - 10
             * 
             * So, BFT should print 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
             * and DFT should print 1, 2, 4, 5, 6, 3, 7, 8, 9, 10
             */
            
            Console.WriteLine($"Traversing using {nameof(BreadthFirstTraverser)}...");  
            
            IEnumerable<int> bfsResult =  new BreadthFirstTraverser().Traverse(tree);
            if (new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.SequenceEqual(bfsResult))
            {
                Console.WriteLine($"{nameof(BreadthFirstTraverser)} is working as expected. Result:");
            }
            else
            {
                Console.WriteLine($"{nameof(BreadthFirstTraverser)} is broken. Result:");
            }
            foreach (var value in bfsResult)
                Console.WriteLine(value);

            Console.WriteLine();
            Console.WriteLine($"Traversing using {nameof(DepthFirstTraverser)}...");

            IEnumerable<int> dfsResult = new DepthFirstTraverser().Traverse(tree);
            if (new[] { 1, 2, 4, 5, 6, 3, 7, 8, 9, 10 }.SequenceEqual(dfsResult))
            {
                Console.WriteLine($"{nameof(DepthFirstTraverser)} is working as expected. Result:");
            }
            else
            {
                Console.WriteLine($"{nameof(DepthFirstTraverser)} is broken. Result:");
            }
            foreach (var value in dfsResult)
                Console.WriteLine(value);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
