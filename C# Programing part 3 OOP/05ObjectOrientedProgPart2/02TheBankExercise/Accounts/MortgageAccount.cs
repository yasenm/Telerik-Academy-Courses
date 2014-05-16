using System;
using System.Collections.Generic;
using System.Linq;

public class MortgageAccount : Account, IDepositable
{
    public int MortgagePeriod { get; private set; }

    public MortgageAccount(Customer accCustomer, decimal balance, decimal interestRate, int mortgagePeriod = 12) : base(accCustomer, balance, interestRate)
    {
        this.MortgagePeriod = mortgagePeriod;
    }

    public void Deposit(decimal deposite)
    {
        Console.WriteLine("Old balance of customer \"{0}\" was : {1}", this.AccCustomer.Name, this.Balance);
        this.Balance += deposite;
        Console.WriteLine("After depositing the amount : {0}. The new balance is : {1}", deposite, this.Balance);
    }

    public decimal CalculateInterest() 
    {
        if (this.MortgagePeriod > 12 && this.AccCustomer is Company)
        {
            return ( this.InterestRate / 2 ) * 12 + this.InterestRate * (this.MortgagePeriod - 12);
        }
        else if (this.AccCustomer is Company)
        {
            return this.InterestRate * this.MortgagePeriod;
        }
        else if (this.MortgagePeriod > 6 && this.AccCustomer is Individual)
        {
            return this.InterestRate * (this.MortgagePeriod - 6);
        }
        else
        {
            return 0;
        }
    }
}
