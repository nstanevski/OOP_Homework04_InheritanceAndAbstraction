using System;

namespace _01_HumanStudentWorker
{
    class Worker:Human
    {
        private int weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            :base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary 
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value <= 0 || value > 1000)
                    throw new ArgumentOutOfRangeException(
                        "Worker's week salary is a number in range[1..1000]"
                        );
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value <= 0 || value > 8)
                    throw new ArgumentOutOfRangeException(
                        "Worker's work hours per day is a number in range[1..8]"
                        );
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            return (double)(WeekSalary/5.0) / (double)WorkHoursPerDay;
        }
    }
}
