using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Katas.Katas.PaginationTest.Model
{
    public class Pagination<T>
    {
        private int _itemsperpage;
        private int _currentpage;

        public IEnumerable<T> Items
        {
            get
            {
                if (CurrentPage > TotalPages)
                {
                    return Enumerable.Empty<T>();

                }

                List<T> listnew = new List<T>();
                List<T> inlist = list.ToList();
                for (int i = 0; i < ItemsPerPage; i++)
                {
                    if (inlist.Count > ((CurrentPage - 1) * ItemsPerPage) + i)
                    {
                        listnew.Add(inlist[((CurrentPage - 1) * ItemsPerPage) + i]);
                    }
                }

                IEnumerable<T> listEnumerable = listnew;
                return listEnumerable;
            }
        }

        public int CurrentPage
        {
            get { return _currentpage; }
            set
            {
                if (value <= 0)
                {
                    _currentpage = 1;
                }

                else
                {
                    _currentpage = value;
                }
            }
        } // gets/sets the current page index, starting at 1

        public int ItemsPerPage
        {
            get
            {
                if (_itemsperpage < 0)
                {
                    return 10;
                }

                return _itemsperpage;
            }
            set
            {

                _itemsperpage = value;

            }
        }
        // gets/sets the number of items to return on each page, default 10 items

        public int Total { get; } // gets the total number of items in the source
        public int TotalPages { get { return ceiling(Total, ItemsPerPage); } } // gets total number of pages

        public IEnumerable<T> list;

        public Pagination(IEnumerable<T> source)
        {
            list = source;
            CurrentPage = 1;
            ItemsPerPage = 10;
            Total = source.Count();

        }

        public static int ceiling(int total, int itemsperpage)
        {
            int totalpages = total / itemsperpage;

            if (total % itemsperpage > 0)
            {
                totalpages++;
            }

            return totalpages;
        }
    }

}