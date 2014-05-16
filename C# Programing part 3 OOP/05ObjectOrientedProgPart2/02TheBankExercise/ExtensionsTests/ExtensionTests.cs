using System;
using System.Collections.Generic;
using System.Linq;

public static class ExtensionTests
{
    public static void TestCustomers(this IEnumerable<Customer> customers) 
    {
        foreach (var customer in customers)
        {
            DepositeAccount custDep = new DepositeAccount(customer, customer.Name.Length * 1000);
            custDep.Deposit(2000);
            custDep.WithDraw(200);
            Console.WriteLine();
            MortgageAccount custMort = new MortgageAccount(customer, customer.Name.Length * 1000, 5);
            custMort.Deposit(3000);
            Console.WriteLine("Interest rate : {0}", custMort.CalculateInterest());
            Console.WriteLine();
            LoanAccount custLoan = new LoanAccount(customer, customer.Name.Length * 1000, 12, 18);
            custMort.Deposit(5000);
            Console.WriteLine("Interest rate : {0}", custLoan.CalculateInterest());
            Console.WriteLine("\n");
        }
    }
}

