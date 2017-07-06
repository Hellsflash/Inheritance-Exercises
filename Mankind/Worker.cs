using System;

namespace Mankind
{
    public class Worker : Human
    {
        private decimal salary;
        private double workHours;

        public Worker(string firstName, string lastName, decimal salary, double workHours)
            : base(firstName, lastName)
        {
            this.WorkHours = workHours;
            this.Salary = salary;
        }

        private double WorkHours
        {
            get { return this.workHours; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHours = value;
            }
        }

        private decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.salary = value;
            }
        }

        public override string ToString()
        {
            return $"First Name: {base.FirstName}\n" +
                   $"Last Name: {base.LastName}\n" +
                   $"Week Salary: {this.Salary:f2}\n" +
                   $"Hours per day: {this.WorkHours:f2}\n" +
                   $"Salary per hour: {(this.Salary / 5.0m / (decimal)(this.WorkHours)):f2}";
        }
    }
}
