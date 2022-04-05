using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Models
{
    internal class Libarary:Book
    {

        public int BookLimit { get; set; }
        List<Book>Books=new List<Book>();
        
       
        public void AddBook(Book book)
        {
            if (Count<=BookLimit)
            {
                BookLimit--;
                Books.Add(book);
                foreach (var item in Books)
                {
                    item.ShowInfo();
                }
            }
            else
            {
                Exception.CapacityLimitException();
            }
  

        }
        public void GetBookById(int?id)
        {
            if (id==null)
            {
                

                throw new System.Exception("Null Reference Exception");

            }
            else
            {
                foreach (var item in Books)
                {
                    if (id==item.Id)
                    {
                        Book book=new Book();
                        book.ShowInfo();
                        foreach (var i in Books)
                        {
                            Console.WriteLine(i);
                        }


                    }
                }
            }

        }
        public void RemoveById(int?id)
        {
            if (id == null)
            {


                throw new System.Exception("Null Reference Exception");

            }
            else
            {
                foreach (var item in Books)
                {
                    if (id == item.Id)
                    { 
                        Books.Remove(item);
                        Book book=new Book();
                        Console.WriteLine($"item.id {item.Id} silindi");
                        book.ShowInfo();
                        foreach (var a in Books)
                        {
                            Console.WriteLine(a);
                        }

                    }
                    else
                    {
                        Exception.NotFoundException();
                    }
                }
            } 

        }

        //ps: BookLimit olmadan Library obyekti yaratmaq olmaz.
        public Libarary(int booklimit)
        { BookLimit=booklimit; 

        }
      
    }
}
