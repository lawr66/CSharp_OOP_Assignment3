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
      /*  double sum;

        //Testing the DisplayInfo() method

        acc.DisplayInfo();
        checking.DisplayInfo();
        savings.DisplayInfo();

        //Testing Transfer() method

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

        //Testing the Transfer() method

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
        */
        /*

        //Testing WithdrawMoney() method

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
        */        

        /*

        //Testing the Serialize() and Deserialize() methods

        checking.Serialize();
        checking.DisplayInfo();
        Account serializedAcc = new Account("223",52000,"John Dough","Savings");
        serializedAcc.DisplayInfo();
        Console.WriteLine(serializedAcc.GetType());
        serializedAcc = serializedAcc.Deserialize();
        serializedAcc.DisplayInfo();
        Console.WriteLine(serializedAcc.GetType());
        */
        List<Account> accounts = new List<Account>
        {
    /*        acc,
            checking,
            savings,*/
        };
   /*   

        //Testing the CompareTo() method by sorting a hardcoded Account list

        Account acc2 = new Account("635",26603,"Mary Smith","Normal");
        CheckingAccount checking2 = new CheckingAccount("122344",6452,"Sam Brown","Checking");
        SavingsAccount savings2 = new SavingsAccount("42451",1234,"John Doe","Savings");
        Account acc3 = new Account("6365",26603,"Mary Smith","Normal");
        CheckingAccount checking3 = new CheckingAccount("1022344",504110,"Sam Brown","Checking");
        SavingsAccount savings3 = new SavingsAccount("424561",1234.54,"John Doe","Savings");
        SavingsAccount savings4 = new SavingsAccount("424591",124234,"John Doe","Savings");
        accounts.Add(acc2);
        accounts.Add(savings2);
        accounts.Add(checking2);
        accounts.Add(acc3);
        accounts.Add(savings3);
        accounts.Add(checking3);
        accounts.Add(savings4);
        //Account[] accounts = new Account[] {acc, checking, savings};      //can also be tested with an array instead of a list
        */

        Random rd = new Random();       //Testing the CompareTo() method by sorting a random Account list
        for(int i = 0; i <= 10; i++)
        {
            accounts.Add(new Account(rd.Next(1,1000).ToString(),rd.Next(500,100000),"John Doe","Normal"));
            //Console.Write("{0} - {1} ",accounts[i].accountNumber, accounts[i].balance);  //checking the accountNumber and balance of the randomly crated accounts
        }
        
        //Console.WriteLine();

        //Writing the accountNumbers before the list is sorted
        for(int i = 0; i < accounts.Count-1; i++)
        {
            Console.Write("{0}, ",accounts[i].accountNumber);
        }
        Console.WriteLine(accounts[accounts.Count-1].accountNumber);
        accounts.Sort();        //sorting the list

        //Writing the accounuNumbers after the list is sorted

        for(int i = 0; i < accounts.Count-1; i++)
        {
            Console.Write("{0}, ",accounts[i].accountNumber);
        }
        Console.WriteLine(accounts[accounts.Count-1].accountNumber);
        
        /*
        for(int i = 0; i < accounts.Count; i++)
        {
            Console.Write("{0} - {1} ",accounts[i].accountNumber, accounts[i].balance); //veryfing if the list was actually sorted after balance
        }
        */
        double sum;       //uncomment if you want to test methods DepositMoney(), WithdrawMoney() or Transfer()
        acc.CheckBalance();
        savings.CheckBalance();
        //checking.DisplayInfo();   //Testing the DisplayInfo() method

        //Testing the Transfer() method

        while(true)
            {
                Console.Write("Introduce the sum you want to transfer.");
                if(double.TryParse(Console.ReadLine(), out sum))
                {
                    (double, double, double) result = acc.Transfer(savings, sum);
                    if(result.Item2 == -1 || result.Item2 == -2)
                    {
                        Console.WriteLine("Introduced sum is higher than current balance ({0})", result.Item1);
                        Console.Write("Do you want to retry? (Y/N)");
                        string answer;
                        answer = Console.ReadLine();
                        if(answer == "Y" || answer == "y")
                        {
                            continue;
                        }
                        else if(answer == "N" || answer == "n")
                        {
                            Console.WriteLine("Transfer cancelled.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid option introduced, transfer cancelled.");
                            break;
                        }
                    }
                    else if(result.Item1==-3)
                    {
                        Console.WriteLine("Error: can't transfer from the same account that you are transferring from.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sucsesfully transferred {0}. The transferer's new balance: {1}. The account's which got the transfer new balance: {2}",result.Item3, result.Item1, result.Item2);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("What you introduced wasn't a number, please retry.");
                }
            } 
      /*
        //Testing the WithdrawMoney() method
        acc.DisplayInfo();
        Console.Write("Introduce the sum you want to withdraw.");
        sum = double.Parse(Console.ReadLine());
        sum = acc.WithdrawMoney(sum);
        if(sum==-1)
        {
            Console.WriteLine("Introduced sum was higher than balance, cannot withdraw money.");
        }
        else
        {   acc.WithdrawMoney(sum);
            acc.DisplayInfo();
        }
        */
        //acc.CheckBalance();   //Testing the CheckBalance() method
      
        //Testing the Serialize() and Deserialize() methods for CheckingAccount type object

        checking.Serialize();
        checking.DisplayInfo();
        Account serializedAcc = checking.Deserialize("1234");
        serializedAcc.DisplayInfo();
  
  /*
        //Testing the Serialize() and Deserialize() methods for SavingsAccount type object

        savings.Serialize();
        savings.DisplayInfo();
        Account serializedAcc = savings.Deserialize("4321");
        serializedAcc.DisplayInfo();
*/

/*
        //Testing the Serialize() and Deserialize() methods for Account type object

        acc.Serialize();
        acc.DisplayInfo();
        Account serializedAcc = acc.Deserialize("12345");
        serializedAcc.DisplayInfo();
 */
    }
}

