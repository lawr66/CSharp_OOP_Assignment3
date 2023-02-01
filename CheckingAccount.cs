using System;

[Serializable]

public class CheckingAccount : Account
{
    public CheckingAccount(string accountNumber, double balance, string ownerName, string accountType) : base(accountNumber, balance, ownerName, accountType)
    {
    }

    public override double Transfer(Account acc, double sum)
    {
        Console.Write("Introduce the sum you want to transfer.");
        while(1>0)
        {
            sum = double.Parse(Console.ReadLine());
            if(sum > this.balance)
            {
                Console.WriteLine("Introduced sum is higher than current balance ({0}), please retry", this.balance);
            }
            else
            {
                this.balance= this.balance - sum;
                acc.balance = acc.balance + sum;
                Console.WriteLine("Transfer between the accounts was successful");
                break;
            }
        }
        return sum;
    }
}