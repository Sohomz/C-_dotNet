using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the library name");
            string libraryName = Console.ReadLine();

            Console.WriteLine("Enter the maximum number of books that can be present");
            int maxBooks=int.Parse(Console.ReadLine());

            Library mylib=new Library(libraryName,maxBooks);

            Console.WriteLine("Enter book titles");
            do
            {
                string input= Console.ReadLine();
                mylib.AddBook(input);
                maxBooks--;
            }while(maxBooks>0);

            mylib.DisplayBooks();
        }
    }
}
