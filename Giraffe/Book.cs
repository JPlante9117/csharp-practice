using System;
using System.Collections.Generic;
using System.Text;

namespace Giraffe
{
    class Book
    {
        public string title;
        public string author;
        private int pages;
        public static int bookCount = 0;

        public Book(string bookTitle, string authorName, int numOfPages)
        {
            Console.WriteLine("Creating Book...");
            title = bookTitle;
            author = authorName;
            Pages = numOfPages;
            bookCount++;
        }

        public int Pages
        {
            get { return pages; }
            set 
            {
                if(value > 0)
                {
                    pages = value;
                } else
                {
                    pages = 1;
                }
            }
        }

        public bool isNovel()
        {
            if(pages > 100)
            {
                return true;
            }
            return false;
        }
    }
}
