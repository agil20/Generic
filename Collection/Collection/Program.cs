using Collection.Models;
using System;
using System.Collections.Generic;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libarary libarary = new Libarary(5);

            Book book1 = new Book("Aqil", 10, "Celil", 100, 1);
            Book book2 = new Book("Fuad",11, "Stefan", 501,1);
            Book book3 = new Book("Ali",12, "Dostayevski", 809,4);
            Book book4 = new Book("Ulvi",8, "Jor", 432,1);
           Book book5 = new Book("Aga",6, "Azrakahan", 603,1);
            Book book6 = new Book("Agalli", 6, "Azrakahan", 209, 1);
            libarary.AddBook(book1);
            libarary.AddBook(book2);

            libarary.AddBook(book3);
            libarary.AddBook(book4);
            libarary.AddBook(book5);
            //libarary.AddBook(book6);
            //book1.Sell();
            //book1.Sell();

            //book2.Sell();
            //book1.Sell();
            //book1.Sell();
            libarary.GetBookById(1);
            //libarary.RemoveById(2);




        }
    }
}
