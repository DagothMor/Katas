using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Katas.Katas.PaginationTest.Model
{
    public class Pagination<T>
    {
        //IEnumerable<T> Items; // gets the items for the current page index
        public int CurrentPage {set { if (value<1) { CurrentPage = 1; } if (value > TotalPages) { var Items = Enumerable.Empty<int>(); } } }      // gets/sets the current page index, starting at 1
        public  int ItemsPerPage{ get { return ItemsPerPage; } set { if (value <= 0) { ItemsPerPage = 10; } } }         // gets/sets the number of items to return on each page, default 10 items
        public  int Total{ get; set; }                // gets the total number of items in the source
        public  int TotalPages{ get; set; }           // gets total number of pages

        /// <summary>
        /// If CurrentPage is set to <= 0 it should default back to page 1.
        /// If CurrentPage is set to > TotalPages Items should be empty (not null).
        /// If ItemsPerPage is set to <= 0 it should default back to 10 items.
        /// Properties listed as only gettable should not be settable.
        /// Settable properties can be set in any order.
        /// </summary>
        /// <param name="source"></param>
        public Pagination(IEnumerable<T> source)
        {
            CurrentPage = 1;
            ItemsPerPage = 10;
            Total = source.Count<T>();
            TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(Total / ItemsPerPage)));
            
        }
        public List<T> ItemInitialization(IEnumerable<T> list, int itemspepage,int currentpage,IEnumerator<T> arrayobjects)
        {
            List<T> listnew = new List<T>();

            for (int i = 0; i < ItemsPerPage; i++) {

                //listnew.Add(arrayobjects[currentpage*itemspepage+i]);
            }
            return listnew;
        }
    }
    
}
