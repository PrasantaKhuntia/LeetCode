using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class NodeList
    {
        public int Data;
        public NodeList Next;

        public NodeList(int data) {

            Data = data;
        }
    }
    public class MergeLinkedList
    {
        public NodeList Merge(NodeList l1, NodeList l2) //l1=1,3,5 l2=2,4,6
        {
            NodeList dummy = new NodeList(0);
            NodeList tail = dummy;

            while(l1 != null && l2 != null)
            {
                if(l1.Data <= l2.Data)
                {
                    tail.Next = l1; //0->1 //0->1->2->3
                    l1 = l1.Next;
                }
                else
                {
                    tail.Next = l2; //0->1->2
                    l2 = l2.Next;
                }
                tail = tail.Next; 
            }
            //0->1->2->3->4->5

            if (l1!=null) tail.Next = l1;
            if(l2!=null) tail.Next = l2; //0->1->2->3->4->5->6

            return dummy.Next;//1->2->3->4->5->6
        }

        public void Display(NodeList curr) //1->2->3->4->5->6
        {
            while (curr != null)
            {
                Console.Write(curr.Data + "->");
                curr = curr.Next;
            }
            Console.WriteLine("Null");
        }
    }
}
