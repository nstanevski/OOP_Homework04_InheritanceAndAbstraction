using System;
using System.Text.RegularExpressions;


using System.Threading.Tasks;

using _03_CompanyHierarchy.Persons.Interfaces;

namespace _03_CompanyHierarchy.Persons.Classes
{
    public abstract class Person:IPerson
    {
        private string id;
        private string fName;
        private string lName;

        protected Person(string id, string fName, string lName)
        {
            this.id = ID;
            this.FName = fName;
            this.LName = lName;
        }

        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                if(!Regex.IsMatch(value, @"^\d{10}$")){
                    throw new ArgumentException("Person ID is a 10-digit long string");
                }
                this.id = value;
            }
        }

        

        public string FName
        {
            get 
            { 
                return this.fName; 
            }
            set 
            { 
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "First name cannot be null, empty or whitespace only string"
                        );
                }
                this.fName = value; 
            }
        }

        public string LName
        {
            get
            {
                return this.lName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Last name cannot be null, empty or whitespace only string"
                        );
                }
                this.lName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} ID: {2}",
                this.FName, this.LName, this.ID);
        }
        

    }
}
