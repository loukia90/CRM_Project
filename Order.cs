using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Project
{
    public class Order
    {
        public string OrderID { get; set; }
        public string DeliveryAddress { get; set; }

        public List<Product> Products { get; set; }
        public decimal TotalAmount
        {
            get
            {
                decimal totalAmount = 0;
                foreach (var product in Products)
                {
                    totalAmount += product.Price;
                }
                return totalAmount;
            }
        }
        public OrderStatus OrderStatus { get; set; }

        public Order()
        {
           Products = new List<Product>();
        }
    }
}
