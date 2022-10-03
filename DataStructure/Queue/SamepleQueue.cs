using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Queue
{
    internal class SamepleQueue
    {
        public int[] Queue { get; set; }
        public int Size { get; set; }
        public int Front { get; set; }
        public int Rear { get; set; }

        public SamepleQueue(int size)
        {
            Size = size;
            Queue = new int[size];
            Front = Rear = -1;
        }

        /// <summary>
        /// inser Element To queue
        /// </summary>
        /// <param name="value"></param>
        public void Inqueue(int value)
        {
            if(IsFull())
            {
                Console.WriteLine("Queue is Full");
                return;
            }

            if(IsEmpty())//if There is No Elemnet Yet incress Front and Rear
            {
                Front = Rear = 0;
                Queue[Rear] = value;
            }
            else//if There is Elements But Queue Not Full incress Rear by one
            {
                Queue[++Rear] = value;
            }
        }

        /// <summary>
        /// Remove Object at begginning 
        /// </summary>
        /// <returns>
        /// The object that is removed
        /// </returns>
        public int Dequeue()
        {
            if(IsEmpty())
            {
                Console.Write("queue is empty");
                return -1;
            }

            return Queue[Front++];

        }

        /// <summary>
        /// Show Element From beginning To End
        /// </summary>
        public void Display()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return;
            }
            for (int i = Front; i <= Rear; i++)
            {
                Console.Write(Queue[i] + " ");
            }
        }
        /// <summary>
        /// Returns The object At The Beginning Without Removeing it
        /// </summary>
        /// <returns>
        /// The object at the beginning 
        /// </returns>
        public int Peek()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return -1;
            }

            return Queue[Front];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// return True if it is Empty otherwise False
        /// </returns>
        public bool IsEmpty()
        {
            return Front == -1 && Rear == -1 || Front > Rear;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            return Rear == Queue.Length - 1;
        }
        /// <summary>
        /// Remove all object From Queue
        /// </summary>
        public void Clear()
        {
            Front = Rear = -1;
        }

    }
}
