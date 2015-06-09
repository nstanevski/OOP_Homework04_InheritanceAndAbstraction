using System;
using System.Text.RegularExpressions;

namespace _01_HumanStudentWorker
{
    class Student:Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            :base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber 
        { 
            get
            {
                return this.facultyNumber;
            }
            set
            {
                string pattern = "^[a-zA-Z0-9]{5,10}$";
                if (!Regex.IsMatch(value, pattern))
                    throw new ArgumentException(
                        "Faculty number contains only numbers and/or digits and is always 5 to 10 digits long"
                        );    
                this.facultyNumber = value;
            }
       }
    }
}
