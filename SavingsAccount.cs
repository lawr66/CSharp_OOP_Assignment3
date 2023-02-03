using System;

[Serializable]

public class SavingsAccount : Account
{
    public SavingsAccount(string accountNumber, double balance, string ownerName, string accountType) : base(accountNumber, balance, ownerName, accountType)
    {
    }

    public override (double,double,double) Transfer(Account acc, double sum)
    {
        if(acc == this)
        {
            return (-3,-3,-3);
        }
        else
        {
            if(sum<=this.balance)
            {
                this.balance = this.balance - sum;
                acc.balance = acc.balance + sum;
                return (this.balance, acc.balance, sum);
            }
            else
            {
                return(this.balance,-2,sum);
            }
        }
    }
}