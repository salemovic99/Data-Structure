using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Tree
{
    class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node()
        {

        }
        public Node(int value)
        {
           Data = value;
           Left = null;
           Right = null;
        }
        
    }
    internal class BInarySearchTree
    {
        public Node Root { get; set; }

        //public void insert(Node root, int value)
        //{
        //    Node NewNode = new Node(value);
           
        //    if(Root == null)//Tree is empty
        //    {
        //        Root = NewNode;
        //        return;
        //    }

        //    if(value < Root.Data)
        //    {
        //       insert(Root.Left, value);
        //    }
        //    else if(value > Root.Data)
        //    {
        //        insert(Root.Right, value);
        //    }
        //}

        public void Find(Node root, int value)
        {
            //if Not Found then return
            if(root == null)
            {
                Console.WriteLine("Not Found!");
                return;
            }

            if( value < root.Data)
            {
                //Console.WriteLine("go left");
                Find(root.Left, value);
            }
            else if(value > root.Data)
            {
                //Console.WriteLine("go right");
                Find(root.Right, value);
            }
            else
            {
                Console.WriteLine("Found(_-_)");
            }
        }

        public void PreOrderTraverse(Node root)
        {
            if(root != null)
            {
                Console.Write(root.Data + " ");
                PreOrderTraverse(root.Left);
                PreOrderTraverse(root.Right);
            }
        }

        public void InOrderTraverse(Node root)
        {
            if (root != null)
            {
                InOrderTraverse(root.Left);
                Console.Write(root.Data + " ");
                InOrderTraverse(root.Right);
            }
        }

        public void PostOrderTraverse(Node root)
        {
            if (root != null)
            {
                PostOrderTraverse(root.Left);
                PostOrderTraverse(root.Right);
                Console.Write(root.Data + " ");
            }
        }
    }

        
}
