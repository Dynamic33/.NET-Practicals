using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace prac6.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDetails { get; set; }
        public string ProductCategory { get; set; }
        public string ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductImage { get; set; }
    }
}