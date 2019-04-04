using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchStoreEmailTool
{
    class CompanyListItem
    {
        public string CompanyName { get; set; }
        public string CompanyID { get; set; }

        public CompanyListItem()
        {
        }

        public CompanyListItem(string companyName, string companyID)
        {
            CompanyName = companyName;
            CompanyID = companyID;
        }
    }
}
