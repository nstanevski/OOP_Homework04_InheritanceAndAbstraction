using System;

using _03_CompanyHierarchy.Persons.Interfaces;


namespace _03_CompanyHierarchy.Persons.Classes
{
    class Customer:Person,ICustomer
    {
        private decimal netPurchaseAmount;

       
        public Customer(string id, string fName, string lName, decimal netPurchaseAmount):
            base(id, fName, lName)
        {
            this.netPurchaseAmount = netPurchaseAmount;
        }

        public Customer(string id, string fName, string lName)
            :this(id,fName, lName, 0.0m)
        {

        }

        public decimal NetPurchaseAmount
        {
            get
            {
                return this.netPurchaseAmount;
            }
        }

        public void AddAmount(decimal amount)
        {
            if(amount<=0.0m)
                throw new ArgumentException("Amount must be positive value");
            this.netPurchaseAmount += amount;
        }

        public void SubtractAmount(decimal amount)
        {
            if (amount <= 0.0m)
                throw new ArgumentException("Amount must be positive value");
            this.netPurchaseAmount -= amount;
        }

        public override string ToString()
        {
            return base.ToString() + 
                string.Format(" Net purchase amount: {0:c}", this.NetPurchaseAmount);
        }
    }
}
