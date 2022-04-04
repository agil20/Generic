using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Models
{
    internal class Exceptionn:Exception
    {
        public  void ProductCountIsZeroException()
        {
            Console.WriteLine("Praducr Count Is Zero Exception");
        }
        public  void CapacityLimitException()
        {
            Console.WriteLine("Capacity Limit Exception");
        }
        public  void NotFoundException()
        {
            Console.WriteLine("Not Faund Exception");
        }
    }
}
