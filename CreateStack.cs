using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CreateStack
    {
        //stack = array + top element
        //stack = LIFO = Last In Fast Out
        //10,20,30,40 - Top
        //push = it adds element to the stack
        //pop = it returns the top element (40) and it changes the top element to its prev element (40->30), stack = 10,20,30
        //push 50 = 10,20,30,50 
        //peek = it returns the top element (50) - stack = 10,20,30,50

        int[] stack;
        int capacity;
        int top;

        public CreateStack(int size) { 
            
            capacity = size;
            stack = new int[capacity];
            top = -1;
        }
        // size = 5 stack = 0,1,2,3,4

        public void push(int value)
        {
            if (top == capacity - 1)
            {
                Console.WriteLine("stack overflow");
                return;
            }
            top = top + 1;
            stack[top] = value;
        }

        public int pop() { 
        
            if(top == -1)
            {
                Console.WriteLine("stack underflow");
                return -1;
            }
            int value = stack[top];
            top = top - 1;
            return value;
        }

        public int peek()
        {

            if (top == -1)
            {
                Console.WriteLine("stack empty");
                return -1;
            }
            int value = stack[top];
            return value;
        }

        public void display()
        {
            if (top == -1)
            {
                Console.WriteLine("stack empty");
                return ;
            }

            for(int i=top; i>=0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }

}
