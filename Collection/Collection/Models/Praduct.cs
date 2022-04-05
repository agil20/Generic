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

        public int Id { get { return   _id; } set{ _id = 1; }} 
        public string Name { get; set; }
        public int Price { get; set; }
        public static int Count { get; set; }
        public static int TotalInCome { get; set; }
        public abstract void Sell();
        public Praduct(string name,int price,int count)
        { Name = name; Price = price; Count = count; 
            _id++;
            
        }
        public abstract void ShowInfo();
    }
}
