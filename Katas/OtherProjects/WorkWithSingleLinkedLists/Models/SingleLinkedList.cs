using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.WorkWithSingleLinkedLists.Models
{
    public class SingleLinkedList<T>
    {
        public class Node<T>
        {
            private T data;
            private Node<T> next = null;

            internal Node<T> Next
            {
                get { return next; }
                set { next = value; }
            }

            internal T Data
            {
                get { return data; }
                set { data = value; }
            }

            internal Node(T d)
            {
                Data = d;
            }
        }

        private int _length;
        internal Node<T> _head;

        public int length
        {
            get { return _length; }
        }

        public SingleLinkedList()
        {
            _length = 0;
            _head = null;
        }

        public void ShowNodes()
        {
            Node<T> current = _head;
            if (current == null)
            {
                Console.WriteLine("Все,закончились ноды");
            }
            else
            {
                ShowLength();
                while (current != null)
                {
                    Console.WriteLine("Node : " + current.Data);
                    current = current.Next;
                }
                Console.WriteLine();
            }



        }

        public void ShowLength() {
            string numString = "Numbers";
            if (_length == 1)
            {
                numString = "number";
            }
            Console.WriteLine(String.Format("List has [{0}] {1}.", _length.ToString(), numString));
        }
        internal void Add(T d)
        {
            Console.WriteLine();
            Console.WriteLine(String.Format("Add node [{0}].", d.ToString()));
            Node<T> newNode = new Node<T>(d);
            Node<T> current = _head;
            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
                // Add new node as the next node to the last node.
                current.Next = newNode;
            }
            _length++;
            ShowNodes();
        }



    }
}

