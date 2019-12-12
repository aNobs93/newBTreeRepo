using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryTreeSearchEngine
{
    class Program
    {
        static void Main(string[] args)
        {

            BinarySearchTree tree = new BinarySearchTree();
            tree.AddToBinaryTree(20);
            tree.AddToBinaryTree(3);
            tree.AddToBinaryTree(3);
            tree.AddToBinaryTree(33);
            tree.AddToBinaryTree(6);
            tree.AddToBinaryTree(1);
            tree.SearchBinaryTree(33);
        }
    }
}
