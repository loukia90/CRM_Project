using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Project
{
    public class SearchCustomerOptions
    {
        public int? Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? MinGrossValue { get; set; }
        public decimal? MaxGrossValue { get; set; }
        public IList<CompanyType> CompanyTypes { get; set; }

        public SearchCustomerOptions()
        {
            CompanyTypes = new List<CompanyType>();
        }
    }
}
