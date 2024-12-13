using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StackCalc
{
    public class CStack
    {
        Node? head;

        public void Push(string data)
        {
            if (!Single.TryParse(data, out float result)) { Fabric fabric = new Fabric(data); }
            if (head == null) { head = new Node(result); }

            Node newNode = new Node(result);
            newNode.next = head;
            head = newNode;
        }
        public Node Pop()
        {
            if (head == null) { return null; }
            Node current = head;
            head = head.next;
            current.next = null;
            return current;
        }

        public void Print()
        {
            Node current = head;
            while(current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}
