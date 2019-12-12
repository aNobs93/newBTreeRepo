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
                Node currentNode = root;
                Node parent;
                while (true)
                {
                    parent = currentNode;
                    if (data < currentNode.data)
                    {
                        currentNode = currentNode.leftChild;
                        if (currentNode == null)
                        {
                            parent.leftChild = node;
                            break;
                        }

                    }
                    else if (data > currentNode.data)
                    {
                        currentNode = currentNode.rightChild;
                        if (currentNode == null)
                        {
                            parent.rightChild = node;
                            break;
                        }
                    }
                    else if (data == currentNode.data && data < root.data)
                    {
                        currentNode = currentNode.leftChild;
                        if (currentNode == null)
                        {
                            parent.leftChild = node;
                            break;
                        }
                    }
                    else if (data == currentNode.data && data > root.data)
                    {
                        currentNode = currentNode.rightChild;
                        if (currentNode == null)
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
                    Console.WriteLine("Your value was not found.");
                    return;
                }
                currentNode = currentNode.rightChild;
                SearchBinaryTree(data, currentNode);
            }
            else if (data < currentNode.data)
            {
                if (currentNode.leftChild == null)
                {
                    Console.WriteLine("Your value was not found.");
                    return;
                }
                currentNode = currentNode.leftChild;
                SearchBinaryTree(data, currentNode);
            }
            else if (data == currentNode.data)
            {
                Console.WriteLine("Your value of: " + data + " was found!");
            }
            else
            {
                Console.WriteLine("Your value cannot be found.");
            }

        }
    }
}
