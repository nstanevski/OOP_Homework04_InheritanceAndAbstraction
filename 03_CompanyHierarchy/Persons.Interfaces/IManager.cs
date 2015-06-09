using System;
using System.Collections.Generic;

using _03_CompanyHierarchy.Persons.Classes;

namespace _03_CompanyHierarchy.Persons.Interfaces
{
    interface IManager
    {
        List<Employee> Employees { get;}
        void AddEmployee(Employee emp);
        void RemoveEmployee(Employee emp);
    }
}
