using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Project
{
    interface ICustomerService
    {
        IReadOnlyList<Customer> SearchCustomers(
            SearchCustomerOptions options);
        
        Customer AddCustomer(Customer customer);
        Customer UpdateCustomer(string vatNumber, Customer customer);
    }

}