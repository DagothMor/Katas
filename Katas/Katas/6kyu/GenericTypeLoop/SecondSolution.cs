using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.Katas._6kyi.GenericTypeLoop
{
    public static class SecondSolution
    {
        public static void Start()
        {
            Loop<string> myLoop = new Loop<string>() { "a", "b", "c", "d", "e", "f" };
            Console.ReadLine();




        }

        public class Loop<T> : IEnumerable<T>
        {
            List<T> linkedList = new List<T>();

            public Loop(IEnumerable<T> source)
            {
                linkedList = source.ToList(); }

            public Loop()
            {
            }

            public void Add(T data)
            {
               linkedList.Add(data);
            }

            public void Left()
            {
                List<T> newlist = new List<T>();
                for(int i = 1; i < linkedList.Count; i++) { newlist.Add(linkedList[i]);}
                newlist.Add(linkedList[0]);
                linkedList = newlist;
            }

            public void Rigth()
            {
                List<T> newlist = new List<T>();
                newlist.Add(linkedList.Last());
                for (int i = 0; i < linkedList.Count-1; i++) { newlist.Add(linkedList[i]); }
                linkedList = newlist;
            }

            public T PopOut()
            {
                // popout the first itme
                T data=linkedList[0];
                linkedList.RemoveAt(0);
                return data;
            }

            public T ShowFirst()
            {
                // show the first item
                T data=linkedList[0];
                return data;
            }

            public IEnumerator<T> GetEnumerator() => linkedList.GetEnumerator();
            //System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => linkedList.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
//((IEnumerable<T>)linkedList).
