using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Linked2
{
    public class LinkedList
    {
        private class Node
        {
            internal int value;
            internal Node next;

            internal Node(int v, Node n)
            {
                value = v;
                next = n;
            }
        }

        private Node head = null;
        private int size = 0;

        //removing duplicate data
        public void RemoveDuplicate()
        {
            if (head == null) //if empty list method returns
            {
                return;
            }

            Node current = head; //starting at the head

            while (current != null) //nested while loop going -- outer loop 
            {
                Node temp = current.next;
                while (temp.next != null) //inner loop checking if any value matched the current value being checked
                {
                    if (temp.next.value == current.value)
                    {
                        temp.next = temp.next.next; // Remove duplicate by setting 
                        size--;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
                current = current.next;
            }
        }


        //Size method
        public int Size()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        // Other Methods.
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("EmptyListException");
            }
            return head.value;
        }

        public void AddHead(int value)
        {
            head = new Node(value, head);
            size++;
        }

        public void AddTail(int value)
        {
            Node newNode = new Node(value, null);
            Node curr = head;

            if (head == null)
            {
                head = newNode;
            }

            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = newNode;
        }

        public int RemoveHead()
        {
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("EmptyListException");
            }
            int value = head.value;
            head = head.next;
            size--;
            return value;
        }

        public bool Search(int data)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.value == data)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        public bool DeleteNode(int delValue)
        {
            Node temp = head;

            if (IsEmpty())
            {
                return false;
            }

            if (delValue == head.value)
            {
                head = head.next;
                size--;
                return true;
            }

            while (temp.next != null)
            {
                if (temp.next.value == delValue)
                {
                    temp.next = temp.next.next;
                    size--;
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        public void Reverse()
        {
            Node curr = head;
            Node prev = null;
            Node next = null;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
        }

        public int FindLength()
        {
            Node curr = head;
            int count = 0;
            while (curr != null)
            {
                count++;
                curr = curr.next;
            }
            return count;
        }

        public void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.value + " ");
                temp = temp.next;
            }
            Console.WriteLine("");
        }
    }

}
