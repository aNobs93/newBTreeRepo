using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryTreeSearchEngine
{
    class Node
    {
        public int data;
        public Node rightChild;
        public Node leftChild;

        public Node(int data)
        {
            this.data = data;
        }
    }
}
