using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Project
{
   public class Product
    {
        public string Code { get; set; }
        public decimal Price { get; set; }  
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductCategory Category { get; set; }


    }
}
