using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Models
{
    internal class Book : Praduct
    {/*Book class (Product-dan miras alır)
- AuthorName
- PageCount*/
        public Book()
        {

        }
        public  string AuthorName { get; set; }
        public int PageCount { get; set; }

        public override void Sell()
        {
            if (Count==0)
            {

               Exception.ProductCountIsZeroException();
            }
            else
            {
                Count--;
                Console.WriteLine($"Name{Name}\n" +
                          
                            $"Count {Count}\n" +
                        
                            $"AuthorName {AuthorName}\n" +
                            $"PageCount {PageCount}");
                TotalInCome++;
            }

            
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name{Name}\n" +
                           
                            $"Count {Count}\n" +
                        
                            $"AuthorName {AuthorName}\n" +
                            $"PageCount {PageCount}");
          
         
        }
        public Book(string name,string authorName,int pageCount,int count)
        {
            Count = count; Name = name; AuthorName = authorName; PageCount = pageCount; 

        }//*ps: name, price, authorName, pageCount dəyərləri olmadan book obyekti yaratmaq olmaz.*/
    }
}
