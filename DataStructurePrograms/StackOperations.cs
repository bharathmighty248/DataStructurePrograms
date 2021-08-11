using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    public class StackOperations<T>
    {
        Node<T> top;
        /// <summary>
        /// This Method Is For Adding Elements
        /// </summary>
        /// <param name="data"></param>
        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("{0} pushed to stack", data);
        }

        /// <summary>
        /// This Method is For Finding Top Element in Stack
        /// </summary>
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack doesn't contains any value");
            }
            else
            {
                Console.WriteLine("\n{ 0} is in top of stack", this.top.data);
            }
        }

        /// <summary>
        /// This Method is For Deleting Elements
        /// </summary>
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack doesn't contains any value");
            }
            else
            {
                Console.WriteLine("Value Popped is {0}", this.top.data);
                top = top.next;
            }
        }

        /// <summary>
        /// This Method Is For Displaying Elements in Stack
        /// </summary>
        public void Display()
        {
            Node<T> temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("\nStack is Empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        /// <summary>
        /// This Method Is For Finding Size 
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            int count = 0;
            Node<T> temp = this.top;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
    }
}
