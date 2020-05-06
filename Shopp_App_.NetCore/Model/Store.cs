using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopp_App_.NetCore.Model
{
    public class Store
    {
        public Store( string nameProduct, decimal quantity, decimal price)
        {
            
            NameProduct = nameProduct;
            Quantity = quantity;
            Price = price;
            Addday = DateTime.Now;
        }

        public int Id { get; set; }
        public string NameProduct { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime Addday { get; set; }


    }
}
