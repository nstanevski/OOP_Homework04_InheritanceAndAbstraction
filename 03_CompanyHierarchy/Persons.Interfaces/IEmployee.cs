using System;

using _03_CompanyHierarchy.Persons.Classes;

namespace _03_CompanyHierarchy.Persons.Interfaces
{
    interface IEmployee
    {
        decimal Salary{ get; set; }
        Department Department{ get; set; }
    }
}
