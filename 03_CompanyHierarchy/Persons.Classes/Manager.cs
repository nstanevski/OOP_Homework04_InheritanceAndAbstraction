using System;
using System.Text;
using System.Collections.Generic;

using _03_CompanyHierarchy.Persons.Interfaces;

namespace _03_CompanyHierarchy.Persons.Classes
{
    public class Manager:Employee,IManager
    {
        private List<Employee> employees;

        public Manager(string id, string fName, string lName, 
            decimal salary, Department department, List<Employee> employees)
            :base(id, fName, lName, salary, department)
        {
            if (employees == null)
                this.employees = new List<Employee>();
            else
                this.employees = employees;
        }

        public List<Employee> Employees
        {
            get { return this.employees; }
        }

        public void AddEmployee(Employee employee)
        {
            if (!this.Employees.Contains(employee))
            {
                this.Employees.Add(employee);
            }
        }

        public void RemoveEmployee(Employee employee)
        {
            if (this.Employees.Contains(employee))
            {
                this.Employees.Remove(employee);
            }
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            StringBuilder sb = new StringBuilder(baseStr);
            if (this.Employees.Count > 0)
            {
                sb.Append("\nSubordinate employees:\n");
                string emplStr = string.Join("\n", this.Employees);
                sb.Append(emplStr);
            }
            return sb.ToString();
        }
    }
}
