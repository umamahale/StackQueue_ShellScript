﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StackUsingLinkedList
{
    class UC2StackUsingLinkedList
    {
        
 
    // A linked list node
    private class Node
        {
            // integer data
            public int data;

            // reference variable Node type
            public Node link;
        }

        // create global top reference variable
        Node top;

        // Constructor
        public UC2StackUsingLinkedList()
        {
            this.top = null;
        }

        // Utility function to add
        // an element x in the stack
        // insert at the beginning
        public void push(int x)
        {
            // create new node temp and allocate memory
            Node temp = new Node();

            // check if stack (heap) is full.
            // Then inserting an element
            // would lead to stack overflow
            if (temp == null)
            {
                Console.Write("\nHeap Overflow");
                return;
            }

            // initialize data into temp data field
            temp.data = x;

            // put top reference into temp link
            temp.link = top;

            // update top reference
            top = temp;
        }

        // Utility function to check if
        // the stack is empty or not
        public bool isEmpty()
        {
            return top == null;
        }

        // Utility function to return
        // top element in a stack
        public int peek()
        {
            // check for empty stack
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
        }

        // Utility function to pop top element from the stack
        public void pop() // remove at the beginning
        {
            // check for stack underflow
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }

            // update the top pointer to
            // point to the next node
            top = (top).link;
        }

        public void display()
        {
            // check for stack underflow
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {

                    // print node data
                    Console.Write("{0}->", temp.data);

                    // assign temp link to temp
                    temp = temp.link;
                }
            }
        }
    }

    // Driver code
    public class GFG
    {
        public static void Main(String[] args)
        {
            // create Object of Implementing class
            UC2StackUsingLinkedList obj = new UC2StackUsingLinkedList();

            // insert Stack value
            obj.push(70);
            obj.push(56);
            obj.push(30);
            

            // print Stack elements
            obj.display();

            // print Top element of Stack
            Console.Write("\nTop element is {0}\n", obj.peek());

            // Delete top element of Stack
            obj.pop();
            obj.pop();

            // print Stack elements
            obj.display();

            // print Top element of Stack
            Console.Write("\nTop element is {0}\n", obj.peek());
        }
    }
}
