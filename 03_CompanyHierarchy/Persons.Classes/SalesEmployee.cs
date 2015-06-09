using System;
using System.Text;
using System.Collections.Generic;

using _03_CompanyHierarchy.Persons.Interfaces;
using _03_CompanyHierarchy.Persons.Tasks;


namespace _03_CompanyHierarchy.Persons.Classes
{
    public class SalesEmployee:RegularEmployee, ISalesEmployee
    {
        private List<Sale> sales;

        public SalesEmployee(string id, string fName, string lName,
            decimal salary, Department department, List<Sale> sales)
            : base(id, fName, lName, salary, department)
        {
            if (sales == null)
                sales = new List<Sale>();
            this.sales = sales;
        }

        public List<Sale> Sales 
        { 
            get
            {
                return this.sales;
            }
        }

        public void AddSale(Sale sale)
        {
            if (!this.Sales.Contains(sale))
                this.Sales.Add(sale);
        }

        public void DeleteSale(Sale sale)
        {
            if (this.Sales.Contains(sale))
                this.Sales.Remove(sale);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder (base.ToString());
            if (this.Sales.Count > 0)
            {
                sb.Append("\nSales list:\n");
                string salesStr = string.Join("\n", this.Sales);
                sb.Append(salesStr);
            }
            return sb.ToString();
        }


       
    }
}
