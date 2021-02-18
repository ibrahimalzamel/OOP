using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{

    //snippet
    class Product //urun
    {

        public int Id { get; set; } 
        public int CategoryId { get; set; }
        public string ProductName { get; set; } // urun adi
        public double UnitPrice { get; set; } // urun fiyati
        public int UnitsInStock { get; set; } //urun stok sayisi

        //CRUD  -- Creat , Read , Update , Delet 

    }
}
