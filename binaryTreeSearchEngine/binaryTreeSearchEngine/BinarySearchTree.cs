using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryTreeSearchEngine
{
    class BinarySearchTree
    {
        Node root;
        int key;
        public BinarySearchTree()
        {
            root = null;
        }
        public void AddToBinaryTree(int data)
        {
            Node node = new Node(data);
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (data < current.data)
                    {
                        current = current.leftChild;
                        if (current == null)
                        {
                            parent.leftChild = node;
                            break;
                        }

                    }
                    else if (data > current.data)
                    {
                        current = current.rightChild;
                        if (current == null)
                        {
                            parent.rightChild = node;
                            break;
                        }
                    }
                    else if (data == current.data && data < root.data)
                    {
                        current = current.leftChild;
                        if (current == null)
                        {
                            parent.leftChild = node;
                            break;
                        }
                    }
                    else if (data == current.data && data > root.data)
                    {
                        current = current.rightChild;
                        if (current == null)
                        {
                            parent.rightChild = node;
                            break;
                        }
                    }
                }
            }

        }
        public void SearchBinaryTree(int data, Node currentNode = null)
        {
            if (currentNode == null)
            {
                currentNode = root;
                SearchBinaryTree(data, currentNode);
            }
            else if (data > currentNode.data)
            {

                if (currentNode.rightChild == null)
                {
                    Console.WriteLine("Your value cannot be found in the binary tree");
                    return;
                }
                currentNode = currentNode.rightChild;
                SearchBinaryTree(data, currentNode);
            }
            else if (data < currentNode.data)
            {
                if (currentNode.leftChild == null)
                {
                    Console.WriteLine("Your value cannot be found in the binary tree");
                    return;
                }
                currentNode = currentNode.leftChild;
                SearchBinaryTree(data, currentNode);
            }
            else if (data == currentNode.data)
            {
                Console.WriteLine("Your value was found!");
            }
            else
            {
                Console.WriteLine("Your value cannot be found in the binary tree");
            }

        }
    }
}
