using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Models
{
    internal class Exception
    {
        public static  void ProductCountIsZeroException()
        {
            //  Console.WriteLine("Praducr Count Is Zero Exception")
            throw new System.Exception("Product Count Is Zero Exception");
        }
        public static void CapacityLimitException()
        {
            throw new System.Exception("Capacity Limit Exception");
        }
        public static  void NotFoundException()
        {
            throw new System.Exception("Not Found Exception");
        }
    }
}
