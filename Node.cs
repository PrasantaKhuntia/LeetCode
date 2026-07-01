using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Node
    {

        //LinkedList = it stores data in node
        //Single LinkedList = it traverse forword = curr, next
        //Doubly LinkedList = it traverse both forword and backword = prev, curr, next
        // 10->20->30->null

        //public Node Prev;
        public int Data;
        public Node Next; 

        public Node( int data) {
            Data = data;
        }   
    }
}
