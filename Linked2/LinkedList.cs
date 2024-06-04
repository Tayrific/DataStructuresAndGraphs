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
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("EmptyListException");
            }

            Node current = head; 

            while (current != null) // Outer loop iterating through each node
            {
                Node temp = current; // Set temp to the node after current
                while (temp.next != null) // Inner loop to compare each node with current
                {
                    if (temp.next.value == current.value)
                    {
                        temp.next = temp.next.next; // Remove duplicates
                        size--; // decrease the size
                    }
                    else
                    {
                        temp = temp.next; 
                    }
                }
                current = current.next; 
            }
        }

        //method for bubble sort

        public void BubbleSort()
        {
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("EmptyListException");
            }

            if (size == 1) //already sorted as only 1
            {
                return;
            }

            bool swapped = true;
            Node current = head;
            Node lastSorted = null;

            while (swapped) //continues until no swaps are make
            {
                swapped = false;
                current = head;

                while (current.next != lastSorted)
                {
                    if (current.value > current.next.value) //switching the values if the one before is bigger
                    {
                        int temp = current.value; 
                        current.value = current.next.value;
                        current.next.value = temp;

                        swapped = true; //swapped turns to true indicating the list might not be sorted
                    }
                    current = current.next;
                }
                lastSorted = current;
            }
        }


        public int NthNodeFromBeginning(int index)
        {
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("EmptyListException");
            }

            if (index < 0 || index >= size )
            {
                throw new IndexOutOfRangeException("index is out of range");
            }

            Node current = head;
            int count = 0;
            while (count < index)
            {
                current = current.next; // Move current to the next node
                count++;
            }

            Console.WriteLine("Value of the {0}th node from the beginning: {1}", index+1, current.value);
            return count;


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
