using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class QueueCreate
    {
        //queue = FIFO = fast in fast out = 10<-20<-30<-40<-50
        //queue = front, rear, array, capacity
        //enqueue = it adds elments to the queue at rear
        //dequeue = it removes element (it changes the front elemnt to it next element) from the queue
        //peek = it gives us the front element

        int[] queue;
        int rear;
        int front;
        int capacity;

        public QueueCreate(int size) { 
        
            capacity = size;
            queue = new int[capacity];
            front = 0;
            rear = -1; //now the is empty
        }

        public void enqueue(int value) { 
        
            if(rear == capacity - 1) 
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            rear++;
            queue[rear] = value;
        }

        public void dequeue()
        {

            if (front > rear)
            {
                Console.WriteLine("Queue Underflow");
                return;
            }
            front++;
            Console.WriteLine(queue[front]);
        }

        public void peek()
        {

            if (front > rear)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine(queue[front]);
        }

        public void display()
        {
            for(int i = front; i<=rear; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }
    }
}
