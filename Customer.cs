using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Project
{
    public class Customer
    {
        public int Age { get; set; }
        public string Email { get; set; }
        public string VatNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TotalGross { get; set; }
        public CompanyType CompanyType { get; set; }

        public Customer()
        {

        }

        public Customer(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new NullReferenceException(
                    nameof(lastName));
            }

            LastName = lastName;
        }

      

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public bool IsAdult()
        {
            return Age >= 18 ? true : false;
        }

        public bool SetMailAddress(string email)
        {
            var isvalid = false;

            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            if (!email.Contains("@"))
            {
                return false;
            }

            if (!(email.EndsWith(".com") ||
              email.EndsWith(".gr")))
            {
                return false;
            }

            isvalid = true;

            if (isvalid == true)
            {
                Email = email;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
   


