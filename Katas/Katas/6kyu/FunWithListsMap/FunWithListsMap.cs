using System;
using System.Text;

namespace Katas.Katas._6kyi.FunWithListsMap
{
    public static class FunWithListsMap
    {
        public static void Start()
        {
            Node<int> node = new Node<int>(1, new Node<int>(2, new Node<int>(3)));

            Node<int> nodenew = Map<int, int>(node, n => n * 2);

            Console.ReadLine();
        }
        public static Node<T2> Map<T, T2>(Node<T> head, Func<T, T2> f)
        {
            ///Иногда возникает необходимость присвоить 
            ///переменным универсальных параметров некоторое начальное значение, 
            ///в том числе и null. Но напрямую мы его присвоить не можем:T id = null;
            ///В этом случае нам надо использовать оператор default(T).
            ///Он присваивает ссылочным типам в качестве значения null
            /// а типам значений - значение 0:
            ///
            /// 
            Node<T> current = head;

            LinkedList<T2> list = new LinkedList<T2>();

            //list.head.data = f(current.data);

            while (current != null)
            {
                list.AddLast(f(current.data));
                current = current.next;
                
            }

            return list.head ;
        }
    }
    public class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node(T data)
        {
            this.data = data;
        }
        public Node(T data, Node<T> next)
        {
            this.data = data;
            this.next = next;
        }
    }

    public class LinkedList<T2>
    {
        public Node<T2> head;
        public void AddLast(T2 data)
        {
            if (head == null)
            {
                head = new Node<T2>(default);

                head.data = data;
                head.next = null;
            }
            else
            {
                Node<T2> toAdd = new Node<T2>(default);
                toAdd.data = data;

                Node<T2> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }
    }

}
//Node<T2> newnode = new Node<T2>(default,null);

//Node<T2> nodeadd = new Node<T2>(default,null);
//newnode.next = newnode;

//newnode = newnode.next;
//newnode.data = f(current.data);

