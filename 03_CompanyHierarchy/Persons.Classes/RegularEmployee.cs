using System;

namespace _03_CompanyHierarchy.Persons.Classes
{
    public abstract class RegularEmployee:Employee
    {
        public RegularEmployee(string id, string fName, string lName,
            decimal salary, Department department)
            :base(id, fName, lName, salary, department)
        {

        }
    }
}
