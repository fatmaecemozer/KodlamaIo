using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet
    class Product
    {
        public int Id { get; set; } //primary key kod okunurluğunu artırıyor
        public int CategoryId { get; set; }

        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

    }
}
