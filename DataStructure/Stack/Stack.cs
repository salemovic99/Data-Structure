using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Stacks
{
    //using array
    internal class myStack
    {
        public int[] Array { get; set; }
        public int Size { get; set; }
        public int Top { get; set; }

        public myStack(int size)
        {
            Size = size;
            Array = new int[Size];
            Top = -1;
        }
        public int Count()
        {
            return Top + 1;
        }
        public bool IsEmpty()
        {
            return Top == -1;
        }
        public bool IsFull()
        {
            return Top == Array.Length - 1;
        }
        public void Push(int value)
        {
            if(IsFull())
            {
                Console.WriteLine("Stack OverFlow!");
                return;
            }

            Array[++Top] = value;
        }
        public void Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack is Empty!");
                return;
            }

            Top--;

        }
        public int Peek()
        {
            return IsEmpty() ? -1 : Array[Top];
        }
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty!");
                return;
            }
            for (int i = Top; i >= 0; i--)
            {
                Console.Write(Array[i] + " ");
            }
        }
    }


    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }

    //Using Linked List
    class Stack
    {
        public Node Top = null;
        public bool IsNull(Node top)
        {
            return Top == null;
        }
        public void Message()
        {
            Console.WriteLine("Stack is Empty!");

        }
        public void Push(int value)
        {
            Node NewNode = new Node(value);
            if(IsNull(Top))
            {
                Top = NewNode;
                return;
            }
            NewNode.Next = Top;
            Top = NewNode;
        }
        public void Pop()
        {
            if(IsNull(Top))
            {
               Message();
                return;
            }

            Top = Top.Next;
        }
        public int Peek()
        {
            return IsNull(Top) ? -1 :  Top.Value;
        }
        public void Display()
        {
            if(IsNull(Top))
            {
                Message();
                return;
            }

            Node current = Top;

            while(current != null)
            {
                Console.WriteLine(current.Value + " ");
                current = current.Next;
            }
        }
    }
}
