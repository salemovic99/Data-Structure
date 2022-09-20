using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedLists
{

    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node()
        {

        }
        public Node(int value)
        {
            Data = value;
        }
        
    }


    internal class LinkedList
    {
        Node head = null;

        //Remove All Item in Linked List
        public void Clear()
        {
            head = null;
        }
        //Check if Linked List Empty
        private bool IsNUll(Node head)
        {
           return head == null;
        }
        //Return Number item of Linked List
        public int Count()
        {
            int count = 0;

            Node current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
        //Add New Item
        public  void insertAtEnd(int value)
        {
            Node NewNode = new Node(value);

            //case one if Linked List has no itmes
            if (IsNUll(head))
            {
                head = NewNode;
                NewNode.Next = null;
                return;
            }

            //case two if Linked List Has Many items
            Node current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = NewNode;
            NewNode.Next = null;
        }
        public void insertAtBegging(int value)
        {
            Node NewNode = new Node(value);

            NewNode.Next = head;
            head = NewNode;
            
        }
        public void RemoveByValue(int value)
        {
            //Point To First Node
            Node current = head;
            Node privous = head;

            //if value Found in first node
            if(current.Data == value)
            {
                head = current.Next;
                return;
            }

            while (current.Data != value)
            {
                privous = current;
                current = current.Next;
            }

            privous.Next = current.Next;
        }
        public void RemoveAtBegging()
        {
            if(IsNUll(head))
            {
                Console.WriteLine("Linked List Is Empty!");
                return;
            }

            head = head.Next;
        }
        public void RemoveAtEnd()
        {
            if(IsNUll(head))
            {
                Console.WriteLine("Linked List is Empty!");
                return;
            }

            if(IsNUll(head.Next))
            {
                head = null;
                return;
            }

            Node PTR = head;

            while (PTR.Next.Next != null)
            {
                PTR = PTR.Next;
            }
            PTR.Next = null;
        }
        public  void Display()
        {
            //case one if Linked List Empty print message
            if (IsNUll(head))
            {
                Console.WriteLine("Linked List is Empty !");
                return;
            }

            //case two if Liked List Has items
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }

        }
    }

}
