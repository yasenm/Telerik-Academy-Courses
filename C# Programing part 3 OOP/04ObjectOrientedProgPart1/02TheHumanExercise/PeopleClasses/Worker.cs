using System;

// Worker inherits FirstName and LastName from Human
public class Worker : Human
{
    public double WeekSalary { get; private set; }

    public double WorkHoursPerDay { get; private set; }

    public Worker(string firstName, string lastName, double weekSalary = 120, double workHoursPerDay = 120) : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
        // Made a method that straight after the initialization calculates the SalaryPerHour more easy made in my opignion
        MoneyPerHour();
    }

    public double SalaryPerHour { get; private set; }

    // The method that calculates the money a worker gets per hour
    private void MoneyPerHour()
    {
        this.SalaryPerHour = this.WeekSalary / ( this.WorkHoursPerDay * 5 );
    }

    // overrided ToString() for the purposes of easy printing for the Worker class
    public override string ToString()
    {
        string result = String.Format("Money per hour : {0,4}lv/h - Worker - {1} {2}.", this.SalaryPerHour, this.FirstName, this.LastName);
        return result;
    }
}
