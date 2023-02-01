using System;
using System.Collections.Generic;

namespace OOP_CSharp_Assignment3;
class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account("12345",2660,"Mary Smith","Normal");
        CheckingAccount checking = new CheckingAccount("1234",500,"Sam Brown","Checking");
        SavingsAccount savings = new SavingsAccount("4321",5000,"John Doe","Savings");
     /*   double sum;

        acc.DisplayInfo();
        checking.DisplayInfo();
        savings.DisplayInfo();
        while(true)
        {
            Console.WriteLine("Introduce the sum you want to transfer.");
            sum = double.Parse(Console.ReadLine());
            if(sum > acc.balance)
            {
                Console.WriteLine("Introduced sum is higher than current balance ({0}), please retry", acc.balance);
            }
            else
            {
                Console.WriteLine("Succesfully transferred {0} to ");
                acc.Transfer(checking,sum);
                break;
            }
        }
        acc.DisplayInfo();
        checking.DisplayInfo();
        while(true)
        {
            Console.WriteLine("Introduce the sum you want to transfer.");
            sum = double.Parse(Console.ReadLine());
            if(sum > acc.balance)
            {
                Console.WriteLine("Introduced sum is higher than current balance ({0}), please retry", acc.balance);
            }
            else
            {
                Console.WriteLine("Succesfully transferred {0} to ",sum);
                checking.Transfer(savings,sum);
                break;
            }
        }
        checking.DisplayInfo();
        savings.DisplayInfo();
        while(true)
        {
            Console.WriteLine("Introduce the sum you want to withdraw.");
            sum = double.Parse(Console.ReadLine());
            if(sum > acc.balance)
            {
                Console.WriteLine("Introduced sum is higher than current balance ({0}), please retry", acc.balance);
            }
            else
            {
                Console.WriteLine("Succesfully withdrawn {0} from your account. ",acc.WithdrawMoney(sum).ToString());
                break;
            }
        }
        acc.DisplayInfo();
        Console.Write("Introduce the sum you want to deposit.");
        sum = double.Parse(Console.ReadLine());
        acc.DepositMoney(sum);
        acc.DisplayInfo();
        acc.CheckBalance();
        checking.Serialize(checking);
        checking.DisplayInfo();
        Account serializedAcc = new Account("223",52000,"John Dough","Savings");
        serializedAcc.DisplayInfo();
        Console.WriteLine(serializedAcc.GetType());
        serializedAcc = serializedAcc.Deserialize();
        serializedAcc.DisplayInfo();
        Console.WriteLine(serializedAcc.GetType());
        */
       /* List<Account> accounts = new List<Account>
        {
            acc,
            checking,
            savings,
        };*/
        Account acc2 = new Account("635",26603,"Mary Smith","Normal");
        CheckingAccount checking2 = new CheckingAccount("122344",6452,"Sam Brown","Checking");
        SavingsAccount savings2 = new SavingsAccount("42451",1234,"John Doe","Savings");
        Account acc3 = new Account("6365",26603,"Mary Smith","Normal");
        CheckingAccount checking3 = new CheckingAccount("1022344",504110,"Sam Brown","Checking");
        SavingsAccount savings3 = new SavingsAccount("424561",1234.54,"John Doe","Savings");
        SavingsAccount savings4 = new SavingsAccount("424591",124234,"John Doe","Savings");
        /*accounts.Add(acc2);
        accounts.Add(savings2);
        accounts.Add(checking2);
        accounts.Add(acc3);
        accounts.Add(savings3);
        accounts.Add(checking3);
        accounts.Add(savings4);*/
        Account[] accounts = new Account[] {acc, checking, savings, acc2, checking2, savings2,acc3, checking3, savings3, savings4};
        for(int i = 0; i < accounts.Length; i++)
        {
            accounts[i].DisplayInfo();
        }
        Array.Sort(accounts);
        for(int i = 0; i < accounts.Length; i++)
        {
            accounts[i].DisplayInfo();
        }
    }
}
