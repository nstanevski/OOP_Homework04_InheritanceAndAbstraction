using System;

namespace _01_HumanStudentWorker
{
    abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName 
        { 
            get
            {
                return this.firstName;
            } 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(
                        "First name cannot be null, empty or whitespace only"
                        );
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(
                        "Last name cannot be null, empty or whitespace only"
                        );
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}", this.FirstName, this.LastName);
        }
    }
}
