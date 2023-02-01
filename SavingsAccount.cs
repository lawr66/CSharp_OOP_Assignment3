using System;

[Serializable]

public class SavingsAccount : Account
{
    public SavingsAccount(string accountNumber, double balance, string ownerName, string accountType) : base(accountNumber, balance, ownerName, accountType)
    {
    }

    public override double Transfer(Account acc, double sum)
    {
        bool isNumber;
        Console.Write("Introduce the sum you want to transfer. ");
        while(1>0)
        {
            isNumber = double.TryParse(Console.ReadLine(), out sum);
            if(isNumber == true)
            {
                if(sum > this.balance)
                {
                    Console.WriteLine("Introduced sum is higher than current balance ({0}), please retry", this.balance);
                }
                else
                {
                    string answer;
                    Console.WriteLine("You are about to send {0} to {1}. Do you want to proceed? (Y/N)",sum,acc.balance);
                    answer = Console.ReadLine();
                    if(string.Equals(answer,"Y",StringComparison.OrdinalIgnoreCase))
                    {   this.balance= this.balance - sum;
                        acc.balance = acc.balance + sum;
                        Console.WriteLine("Transfer between the accounts was successful");
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Entered value isn't a number, please try again.");
            }
        }
        return sum;
    }
}