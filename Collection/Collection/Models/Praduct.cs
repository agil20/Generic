using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Models
{
   abstract class Praduct
    {/* - Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq və hər dəfə yeni bir Book obyekt yaradıldıqda avtomatik bir vahid artacaq.
  - Name
  - Price
  - Count
  - TotalInCome - book satışlarından alınan gəlir sadəcə Productın miras verdiyi class-larda set etmək olar
  - Sell() - abstrakt method olacaq*/
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
