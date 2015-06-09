using System;

namespace _03_CompanyHierarchy.Persons.Interfaces
{
    interface IPerson
    {
        string ID { get; set; }
        string FName { get; set; }
        string LName { get; set; }
    }
}
