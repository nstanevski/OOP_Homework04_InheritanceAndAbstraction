using System;

namespace _03_CompanyHierarchy.Persons.Interfaces
{
    interface ICustomer
    {
        decimal NetPurchaseAmount { get; }
        void AddAmount(decimal amount);
        void SubtractAmount(decimal amount);
    }
}
