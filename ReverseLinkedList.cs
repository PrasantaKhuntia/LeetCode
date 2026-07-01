using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class NodeItem
    {
        public int Data;
        public NodeItem Next;

        public NodeItem(int data)
        {
            Data = data; 
            Next = null;
        }
    }
    public class ReverseLinkedList
    {
        NodeItem head;
        public void Add(int data)
        {
            NodeItem newNode = new NodeItem(data);

            if (head == null)
            {
                head = newNode;
                return;
            }
            NodeItem curr = head;

            while (curr.Next != null)
            {
                curr = curr.Next; //traverse to the last node //10->20->30->40
            }

            curr.Next = newNode;
            
        }

        public void Reverse()
        {
            NodeItem prev = null;
            NodeItem curr = head;
            NodeItem next = null;

            while(curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            head = prev; //40->30->20->10
        }

        public void Display()
        {
            NodeItem curr = head;

            while(curr != null)
            {
                Console.Write(curr.Data + "->");
                curr = curr.Next;
            }
            Console.WriteLine("Null"); //40->30->20->10->Null
        }
    }
}
