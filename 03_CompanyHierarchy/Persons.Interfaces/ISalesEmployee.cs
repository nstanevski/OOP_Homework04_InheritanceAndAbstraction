using System;
using System.Collections.Generic;


using _03_CompanyHierarchy.Persons.Tasks;

namespace _03_CompanyHierarchy.Persons.Interfaces
{
    interface ISalesEmployee
    {
        List<Sale> Sales {get;}
        void AddSale(Sale sale);
        void DeleteSale(Sale sale);
    }
}
