using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonaccifila
{
    internal class Node
    {
        Node? next = null;
        int data;

        public Node(int data)
        {
            this.data = data;
        }

        public Node? Next() { return next; }

        public void SetNext(Node? node) { next = node; }

        public int GetData() { return data; }
    }
}
