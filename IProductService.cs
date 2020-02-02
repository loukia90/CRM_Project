using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Project
{
    interface IProductService
    {
        void AddProduct(Product product);
        void RemoveProduct(string code);
    }
}
