using System;
namespace Problem1HumanStudentAndWorker
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName) 
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Your week salary cannot be negative!");
                }
                weekSalary = value; 
            }
        }
        public decimal WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Your work hours per day cannot be negative!");
                }
                workHoursPerDay = value; 
            }
        }

        public string MoneyPerHour(decimal weekSalary, decimal workHoursPerDay) 
        {
            decimal workHoursPerWeek = workHoursPerDay * 7;
            decimal moneyPerHour = weekSalary / workHoursPerWeek;
            return string.Format("{0:f2}", moneyPerHour);
        }

        public override string ToString()
        {

            return base.ToString() + " - " + MoneyPerHour(this.WeekSalary, this.WorkHoursPerDay) + " lv.";
        }
    }
}
