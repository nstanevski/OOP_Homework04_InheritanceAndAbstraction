using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _03_CompanyHierarchy.Persons.Interfaces;

namespace _03_CompanyHierarchy.Persons.Classes
{
    public enum Department {Production, Accounting, Sales, Marketing};
    public abstract class Employee:Person,IEmployee
    {
        private decimal salary;
        private Department department;

        protected Employee(string id, string fName, string lName, 
            decimal salary, Department department)
            :base(id, fName, lName)
        {
            this.Salary = salary;
            this.Department = department;

        }

	    public decimal Salary
	    {
		    get 
            {
                return this.salary;
            }
		    set 
            {
                if (value < 0.0m || value >= 100000.00m)
                    throw new ArgumentOutOfRangeException("Salary is a value in range[0..100000]");
                this.salary = value;
            }
	    }


        public Department Department
        {
            get 
            { 
                return this.department; 
            }
            set
            {
                if ((int)value < 0 || (int)value > 3)
                {
                    throw new ArgumentOutOfRangeException("Department out of specified range");
                }
                this.department = value;
            }
                
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" Salary: {0:c} Department: {1}", 
                this.Salary, this.Department);
        }
        

    }
}
