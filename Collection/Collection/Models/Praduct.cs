using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Models
{
   abstract class Praduct
    {
        private static int _id;

        public int Id { get { return _id; } }
        public string Name { get; set; }
        public int Price { get; set; }
        public static int Count { get; set; }
        public static int TotalInCome { get; set; }
        public abstract void Sell();
        public Praduct()
        {
            _id++;
            
        }
        public abstract void ShowInfo();
    }
}
