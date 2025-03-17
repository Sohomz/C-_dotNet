using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Library
    {
        private string _libraryName;
        private int _bookEntered;
        private int _bookCounts = 0;
        private List<string> books=new List<string> { };

        public Library(string name, int maxBooks) //parametarized constructor
        {
            _libraryName = name;
            _bookEntered = maxBooks;
            Console.WriteLine($"Libray Name: {_libraryName}\nMax number of book:{_bookEntered}");
        }

        public void AddBook(string bookTitle)
        {
            if (_bookEntered > 0)
            {
                _bookCounts++;
                books.Add(bookTitle);
                Console.WriteLine($"Book {bookTitle} added to the library");
                _bookEntered--;
            }
            else
            {
                Console.WriteLine("Library is full");
            }
        }
        public void DisplayBooks()
        {
            Console.WriteLine($"Books available in the library {_libraryName}");
            int i = 0;
            while (i<books.Count)
            {
                Console.WriteLine(books[i]);
                i++;
            }
        }
        ~Library()//desturctor
        {
            Console.WriteLine($"Library {_libraryName} is destroyed");
        }
    }
}
