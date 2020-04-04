using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Katas.Katas._7katas.Convert_a_linked_list_to_a_string
{
    public static class ConvertALinkedListToAString
    {
        public static void Start()
        {
            Node node1 = new Node(1, new Node(2, new Node(3)));
            //string n = Stringify(node1);
            ;

            //Console.WriteLine(n);
            Console.ReadLine();
        }

       // public static string Stringify(Node list)
      //  {
           // Node<T> current = head;
            //while (current != null)
          //  {
          //      yield return current.Data;
         //       current = current.Next;
         //   }
         //   
       // }
    }

    public class Node
    {
        public int Data { get; private set; }
        public Node Next { get; private set; }

        public Node(int data, Node next = null)
        {
            Data = data;
            Next = next;
        }
    }
}
