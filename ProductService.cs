using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Project
{
    public class ProductService : IProductService
    {
        public IList<Product> ProductList;
        public void AddProduct(Product product)
        {
            ProductList.Add(product);
        }
        public void RemoveProduct(string code)
        {
            foreach (var product in new List<Product>(ProductList))
            {
                if (code == product.Code)
                {

                    ProductList.Remove(product);
                }
            }
        }
        public ProductService()
        {

            ProductList = new List<Product>();


        }
    }
}
