using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class QueueOperations<T>
    {
        public Node<T> head = null;
        /// <summary>
        /// This Method Is For Enqueing Elements
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is inserted into Queue", newNode.data);
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine("{0} is inserted into Queue", newNode.data);
            }
        }
        /// <summary>
        /// This Method Is For Dequeing Elements
        /// </summary>
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("\nQueue is Empty,Deletion is Not Possible");
                return;
            }
            else
            {
                this.head = this.head.next;
            }
        }
        /// <summary>
        /// This Method Is For Displaying Who Are In The Queue
        /// </summary>
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\nQueue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
