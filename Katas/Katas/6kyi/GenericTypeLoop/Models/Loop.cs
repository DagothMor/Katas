using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._6kyi.GenericTypeLoop.Models
{
    public class Loop<T>
    {
        public Node<T> _head;

        public Node<T> _tail;

        public int _count;

        public Node<T> Head => _head;
        public Node<T> Tail => _tail;
        public int Count => _count;

        public Loop(IEnumerable<T> source)
        {


        }
        public IEnumerator GetEnumerator<T>()
        {
            throw new NotImplementedException();
        }



        public void AddLast(T item)
        {
            if (_head == null)
                this.AddFirstItem(item);
            else
            {
                Node<T> newNode = new Node<T>(item);
                _tail.Next = newNode;
                newNode.Next = _head;
                newNode.Previous = _tail;
                _tail = newNode;
                _head.Previous = _tail;
            }
            _count++;
        }

         void AddFirstItem(T item)
        {
            _head = new Node<T>(item);
            _tail = _head;
            _head.Next = _tail;
            _head.Previous = _tail;
        }
         public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = _head;
            if (current != null)
            {
                do
                {
                    yield return current.data;
                    current = current.Next;
                } while (current != _head);
            }
        }
    }
    public class Node<T>
    {
        public T data;
        public Node<T> Next;
        public Node<T> Previous;
        public Node(T Data)
        {
            data = Data;
        }
    }
}


