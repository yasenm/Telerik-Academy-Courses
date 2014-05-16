using System;
using System.Collections.Generic;
using System.Linq;

public class LoanAccount : Account, IDepositable
{
    public int LoanPeriod { get; private set; }

    public LoanAccount(Customer accCustomer, decimal balance, decimal interestRate, int loanPeriod = 6) : base(accCustomer, balance, interestRate)
    {
        this.LoanPeriod = loanPeriod;
    }

    public void Deposit(decimal deposite)
    {
        Console.WriteLine("Old balance of customer \"{0}\" was : {1}", this.AccCustomer.Name, this.Balance);
        this.Balance += deposite;
        Console.WriteLine("After depositing the amount : {0}. The new balance is : {1}", deposite, this.Balance);
    }

    public decimal CalculateInterest() 
    {
        if (this.LoanPeriod > 2 && this.AccCustomer is Company)
        {
            return this.InterestRate * 2;
        }
        else if (this.AccCustomer is Company)
        {
            return this.InterestRate * this.LoanPeriod;
        }
        else if (this.LoanPeriod > 3 && this.AccCustomer is Individual)
        {
            return this.InterestRate * 3;
        }
        else if (this.AccCustomer is Individual)
        {
            return this.InterestRate * this.InterestRate;
        }
        else
        {
            return 0;
        }
    }
}
