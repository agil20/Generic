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
        public  string AuthorName { get; set; }
        public int PageCount { get; set; }

        public override void Sell()
        {
            if (Count==0)
            {
                Exceptionn exception = new Exceptionn();
                exception.ProductCountIsZeroException();
            }
            return;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name{Name}\n" +
                            $"Price {Price}\n" +
                            $"Count {Count}\n" +
                            $"TotalInCome {TotalInCome}\n" +
                            $"AuthorName {AuthorName}\n" +
                            $"PageCount {PageCount}");
            Count--;
            TotalInCome++;
        }
        public Book(string name,string authorName,int pageCount)
        { Name = name; AuthorName = authorName; PageCount = pageCount; 

        }//*ps: name, price, authorName, pageCount dəyərləri olmadan book obyekti yaratmaq olmaz.*/
    }
}
