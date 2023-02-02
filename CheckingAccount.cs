using System;

[Serializable]

public class CheckingAccount : Account
{
    public CheckingAccount(string accountNumber, double balance, string ownerName, string accountType) : base(accountNumber, balance, ownerName, accountType)
    {
    }

    public override (double, double, double) Transfer(Account acc, double sum)
    {
        if(sum<this.balance)
        {
            this.balance = this.balance - sum;
            acc.balance = acc.balance + sum;
            return (this.balance, acc.balance, sum);
        }
        else
        {
            return(this.balance,-1,sum);
        }
    }
}