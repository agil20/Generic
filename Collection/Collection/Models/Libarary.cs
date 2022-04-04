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
        public int Count { get; set; }
        //- AddBook() - Parametr olaraq bir Book obyekti qəbul edir və books listinə əlavə edir əgər BookLimiti
        //aşırsa geriyə CapacityLimitException qaytarsın
        public void AddBook(Book book)
        {
            if (Count<=BookLimit)
            {
                Books.Add(book);
            }
            else
            {
                Exception.CapacityLimitException();
            }
   //- GetBookById() - Parametr olaraq nullable bir id qəbul edir və
   //o Book obyektini tapıb geriyə qaytarır əgər id null olarsa geriyə NullReferenceException qaytarsın
   //ümumiyyətlə göndərilən id-li book-u tapmasa geriyə null qaytarsın.

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

                    }
                }
            }

        }
        /*- RemoveById() - Parametr olaraq nullable bir id qəbul edir və o Book obyektini tapıb 
                    * Books listindən silir əgər id null olarsa geriyə
                 * NullReferenceException qaytarsın ümumiyyətlə göndərilən id-li book-u tapmasa geriyə*/
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
        public override void Sell()
        {
            
        }
    }
}
