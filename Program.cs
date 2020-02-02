using System;

namespace CRM_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");
            

            // Testing Total Amount
            Console.WriteLine("Testing Total Amount");


            var product1 = new Product()
            {
                Price = 12.0m,
                Code = "abc"
            };

            var product2 = new Product()
            {
                Price = 11.0m,
                Code ="1d2d"
            };

          
            var order1 = new Order();

            order1.Products.Add(product1);
            order1.Products.Add(product2);

            Console.WriteLine(order1.TotalAmount);

            // Testing ProductService.AddProduct
            Console.WriteLine("Testing ProductService.AddProduct");

            var productService = new ProductService();

            productService.AddProduct(product1);
            productService.AddProduct(product2);


            foreach (var product in productService.ProductList)
            {
                Console.WriteLine(product.Price);
            }

            //Testing ProductService.RemoveProduct;
            Console.WriteLine("Testing ProductService.RemoveProduct");

            productService.RemoveProduct(product1.Code);
            foreach (var product in productService.ProductList)
            {
                Console.WriteLine(product.Price);
            }

            //Testing CustomerService.AddCustomer;
            Console.WriteLine("Testing CustomerService.AddCustomer");

            var customerService = new CustomerService();
            
            var customerLoukia = new Customer()
            {
                Age = 18,
                FirstName = "Loukia",
                LastName = "Fereti",
                VatNumber = "123",
                Email = "l@hotmail.com"
            };

            var customerVaggelis = new Customer()
            {
                Age = 19,
                FirstName = "Vaggelis",
                LastName = "Panopoulos",
                VatNumber = "1256",
                Email = "v@hotmail.com"
            };


            customerService.AddCustomer(customerLoukia);

            foreach (var customer in customerService.customers)
            {
                Console.WriteLine(customer.VatNumber);
            }

            //Testing CustomerService.UpdateCustomer;
            Console.WriteLine("Testing CustomerService.UpdateCustomer");

            customerService.UpdateCustomer("123", customerVaggelis);
            
            foreach (var customer in customerService.customers)
            {
                Console.WriteLine(customer.VatNumber);
            }




        }

        
    }
}
