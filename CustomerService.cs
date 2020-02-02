using System;
using System.Collections.Generic;
using System.Linq;

namespace CRM_Project
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> customers = new List<Customer>() {
            new Customer() {
                Age = 55,
                FirstName = "Dimitris",
                LastName = "PnevmatiKOS",
                VatNumber = "145"
            },
        };

        public IReadOnlyList<Customer> SearchCustomers(
            SearchCustomerOptions options)
        {
            if (customers == null)
            {
                return null;
            }

            if (customers.Count() == 0)
            {
                return new List<Customer>();
            }

            var results = customers
                .AsEnumerable()
                .Where(c => c != null);

            if (!string.IsNullOrWhiteSpace(options.LastName))
            {
                results = results.Where(c =>
                    !string.IsNullOrWhiteSpace(c.LastName) &&
                    c.LastName.Equals(
                    options.LastName, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(options.FirstName))
            {
                results = results.Where(c =>
                    !string.IsNullOrWhiteSpace(c.FirstName) &&
                    c.FirstName.Equals(
                    options.FirstName, StringComparison.OrdinalIgnoreCase));
            }

            if (options.Age != null && options.Age > 0)
            {
                results = results.Where(c => c.Age == options.Age.Value);
            }

            if (options.MaxGrossValue != null &&
              options.MaxGrossValue > 0)
            {
                results = results.Where(c =>
                    c.TotalGross <= options.MaxGrossValue.Value);
            }

            if (options.MinGrossValue != null &&
                options.MinGrossValue > 0)
            {
                results = results.Where(c =>
                    c.TotalGross >= options.MinGrossValue.Value);

            }

            if (options.CompanyTypes.Count() != 0)
            {
                results = results.Where(c =>
                    options.CompanyTypes.Contains(c.CompanyType));
            }

            return results.ToList();
        }

        public Customer AddCustomer(Customer customer)
        {
            var newCustomer = new Customer();

            if (!string.IsNullOrWhiteSpace(customer.FirstName))
            {
                newCustomer.FirstName = customer.FirstName;
            }

            if (!string.IsNullOrWhiteSpace(customer.LastName))
            {
                newCustomer.LastName = customer.LastName;
            }
            
            if (string.IsNullOrWhiteSpace(customer.Email))
            {
                return null;
            }else
            {
                newCustomer.Email = customer.Email;
            }

            if (!string.IsNullOrWhiteSpace(customer.VatNumber))
            {
                newCustomer.VatNumber = customer.VatNumber;

                var exists = customers
                    .Where(c => c.VatNumber.Equals(
                        customer.VatNumber,
                        StringComparison.OrdinalIgnoreCase))
                    .Any();

                if (exists)
                {
                    return null;
                }

            }
            else
            {
                return null;
            }

            customers.Add(newCustomer);

            return newCustomer;
        }

        public Customer UpdateCustomer(string vatNumber, Customer customer)
        {
            for (int i = 0; i < customers.Count ; i++)
            {
                if  (customers[i].VatNumber == vatNumber)
                {
                    customers[i] = customer;
                    return customer;
                }
            }
            return null;
        }
                

            }
        }