using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    internal class Book
    {
        public int Id;
        public string Title;
        public int Price;
        public int Page;

        public Book()
        {
            Id = 0;
            Title = "";
            Price = 0;
            Page = 0;

        }
        public Book(int id, string title, int price, int page)
        {
            Id = id;
            Title = title;
            Price = price;
            Page = page;
        }
    }
}
