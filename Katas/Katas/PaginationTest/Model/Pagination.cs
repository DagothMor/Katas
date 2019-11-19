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
        //IEnumerable<T> Items 
           
         // gets the items for the current page index
        public int CurrentPage
        {
            get
            {
                return _currentpage;
            }
            set
            {
                if (value < 1) { _currentpage = 1; }

                if (value > TotalPages)
                {
                    var Items = Enumerable.Empty<int>();
                }
                else
                {
                    _currentpage = value;
                }
            }
        }      // gets/sets the current page index, starting at 1
        public int ItemsPerPage
        {
            get { return _itemsperpage; }
            set
            {
                if (value <= 0)
                {
                    _itemsperpage = 10;
                }
                else
                {
                    _itemsperpage = value;
                }
            }
        }         // gets/sets the number of items to return on each page, default 10 items
        public int Total { get; set; }                // gets the total number of items in the source
        public int TotalPages { get; set; }           // gets total number of pages

        private List<T> list;
        /// <summary>
        /// If CurrentPage is set to <= 0 it should default back to page 1.(checked)
        /// If CurrentPage is set to > TotalPages Items should be empty (not null).(checked)
        /// If ItemsPerPage is set to <= 0 it should default back to 10 items.(checked)
        /// Properties listed as only gettable should not be settable.
        /// Settable properties can be set in any order.
        /// </summary>
        /// <param name="source"></param>
        public Pagination(IEnumerable<T> source)
        {
            List<T> list = source.ToList();
            CurrentPage = 1;
            ItemsPerPage = 10;
            Total = source.Count<T>();
            TotalPages = Convert.ToInt32(Math.Ceiling((double)Total / ItemsPerPage));
        }

        public IEnumerable<T> Items
        {
            get
            {
                List<T> listnew = new List<T>();
                List<T> inlist = list.ToList();

                for (int i = 0; i < ItemsPerPage; i++)
                {

                    listnew.Add(inlist[(CurrentPage * ItemsPerPage) + i]);
                }

                return listnew;
            }
        }
    }

}
