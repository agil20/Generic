using Collection.Models;
using System;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libarary libarary = new Libarary(4);
            Book book1=new Book("Aqil,","CelilMemmedQuluzade",234,2);
            Book book2 = new Book("Fuad", "Stefan", 501,1);
            Book book3 = new Book("Ali", "Dostayevski", 809,4);
            Book book4 = new Book("Ulvi", "Jor", 432,1);
           Book book5 = new Book("Aga", "Azrakahan", 603,1);
            libarary.AddBook(book1);
            libarary.AddBook(book2);
            libarary.AddBook(book3);
            libarary.AddBook(book4);
            libarary.AddBook(book5);
            book1.Sell();
            //book2.Sell();
            //book1.Sell();
            //book1.Sell();
            //libarary.GetBookById(1);
            //libarary.RemoveById(2);




        }
    }
}
