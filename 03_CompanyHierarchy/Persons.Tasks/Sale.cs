using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CompanyHierarchy.Persons.Tasks
{
    public class Sale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Sale name cannot be null or empty");
                this.productName = value; 
            }
        }

        public DateTime Date
        {
            get { return this.date; }
            set
            {
                if (value.GetType().Name != "DateTime")
                    throw new ArgumentException("Sale date must be DateTime object");
                if (value < DateTime.Now)
                    throw new ArgumentException("Sale date cannot be past");
                this.date = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0.0m)
                    throw new ArgumentOutOfRangeException("Sale price cannot be negative");
                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} Date: {1} Price: {2:c}",
                this.ProductName, this.Date, this.Price);
        }
        
    }
}
