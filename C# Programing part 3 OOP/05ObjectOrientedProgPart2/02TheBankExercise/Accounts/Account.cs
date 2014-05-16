using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Account
{
    public Customer AccCustomer { get; private set; }
    public decimal Balance { get; set; }
    public decimal InterestRate { get; set; }

    public Account(Customer accCustomer, decimal balance, decimal interestRate)
    {
        this.AccCustomer = accCustomer;
        this.Balance = balance;
        this.InterestRate = interestRate;
    }
}
