using System;

//A bank account has a holder name (first name, middle name and last name),
//available amount of money (balance), bank name, IBAN, BIC code and 3 credit
//card numbers associated with the account. Declare the variables needed to keep
//the information for a single bank account using the appropriate data types and
//descriptive names.

class BankAcount
{
    static void Main()
    {
        string firstName = "Pantaley";
        string middleName = "Pantaleev";
        string lastName = "Hadjipantaleevski";
        int balance = 5000;
        string currentBank = "OPB Obedinena Pantaleevska Banka";
        string IBAN = "lotsOfLettersAndNumbers129803901";
        string BIC = "BG01UNN5640951234";
        long creditCard1 = 1234567891011121;
        long creditCard2 = 1234567891011122;
        long creditCard3 = 1234567891011123;
        Console.WriteLine("First name : {0}", firstName);
        Console.WriteLine("Middle name : {0}", middleName);
        Console.WriteLine("Last name : {0}", lastName);
        Console.WriteLine("Balance in card : {0}", balance);
        Console.WriteLine("Bank used : {0}", currentBank);
        Console.WriteLine("IBAN : {0}", IBAN);
        Console.WriteLine("BIC code : {0}", BIC);
        Console.WriteLine("Credit card number for card 1 : {0}", creditCard1);
        Console.WriteLine("Credit card number for card 2 : {0}", creditCard2);
        Console.WriteLine("Credit card number for card 3 : {0}", creditCard3);
    }
}
