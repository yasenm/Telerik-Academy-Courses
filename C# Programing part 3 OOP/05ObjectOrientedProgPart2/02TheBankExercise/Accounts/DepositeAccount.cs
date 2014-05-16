using System;
using System.Collections.Generic;
using System.Linq;

public class DepositeAccount : Account, IDepositable, IWithDraw
{
    public DepositeAccount(Customer accCustomer, decimal balance, decimal interestRate = 0) : base(accCustomer, balance, interestRate)
    {
    }

    public void Deposit(decimal deposite)
    {
        Console.WriteLine("Old balance of customer \"{0}\" was : {1}", this.AccCustomer.Name, this.Balance);
        this.Balance += deposite;
        Console.WriteLine("After depositing the amount : {0}. The new balance is : {1}", deposite, this.Balance);
    }

    public void WithDraw(decimal withDraw)
    {
        Console.WriteLine("Customer : {0}. Wants to withdraw {0}lv from its account with current balance : {2};", this.AccCustomer.Name, withDraw, this.Balance);
        this.Balance -= withDraw;
        Console.WriteLine("New balance after withdraw : {0}", this.Balance);
    }

    public decimal CalculateInterest() 
    {
        if (this.Balance < 1000)
        {
            this.InterestRate = 0;
            return this.InterestRate;
        }
        return this.InterestRate;
    }
}
