using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Models
{
    internal class Libarary
    {
        public int Count { get; set; }
        public int BookLimit { get; set; }
        List<Book>Books=new List<Book>();
        
       
        public void AddBook(Book book)
        {
            if (Count<=BookLimit)
            {
                BookLimit--;
                Books.Add(book);
              
                Console.WriteLine($"elave olundu {book.Name} sayi {book.Count} yazici {book.AuthorName} id'si {book.Id} qiymeti  {book.Price} Sehive sayi {book.PageCount} ");
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
                        Console.WriteLine("Istediyiniz kitab");
                        item.ShowInfo();
                       


                    }
                }
            }

        }
        public void RemoveById(int?id)
        {
            foreach (var item in Books)
            {
                if (id == item.Id)
                {
                    Console.WriteLine($"Silindi {item.Id}");
                    item.ShowInfo();
                }
                else if (id == null)
                {
                    throw new System.Exception();
                }
                

            } 
            
           

        }

        //ps: BookLimit olmadan Library obyekti yaratmaq olmaz.
        public Libarary(int booklimit)
        { BookLimit=booklimit; 

        }
      
    }
}
