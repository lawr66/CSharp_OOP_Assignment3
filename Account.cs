using System;
using System.IO;
using System.Text.Json;
using System.Runtime.Serialization;

[Serializable]
public class Account : IComparable, ISerializable
{
    private string _accountNumber;
    private double _balance;
    private string _ownerName;
    public string AccountType {get; set;}

    public string accountNumber
    {
        get
        {
            return _accountNumber;
        }
        set
        {
            _accountNumber = value;
        }
    }

    public double balance
    {
        get
        {
            return _balance;
        }
        set
        {
            _balance = value;
        }
    }

        public string ownerName
    {
        get
        {
            return _ownerName;
        }
        set
        {
            _ownerName = value;
        }
    }

    private Account()
    {

    }

    public void Serialize()
    {
        string fileName = string.Format("Account_{0}.json",this._accountNumber); 
        string jsonString = JsonSerializer.Serialize(this);
        File.WriteAllText(fileName, jsonString);
    }

    public Account Deserialize(string accNumber)
    {
        try
        {
        string fileName = string.Format("Account_{0}.json",accNumber);
        string jsonString = File.ReadAllText(fileName);
        Account acc = JsonSerializer.Deserialize<Account>(jsonString);
        if(string.Equals(acc.AccountType,"Checking",StringComparison.OrdinalIgnoreCase))
        {
            acc = new CheckingAccount(acc._accountNumber,acc._balance,acc._ownerName,AccountType);
        }
        else if(string.Equals(acc.AccountType,"Savings",StringComparison.OrdinalIgnoreCase))
        {
            acc = new SavingsAccount(acc._accountNumber,acc._balance,acc._ownerName,AccountType);
        }
        return acc;
        }
        catch (Exception)
        {
            Console.WriteLine("Couldn't find specified account number.");
            Account acc = new Account();
            return acc;
        }
    }
    public Account(string accountNumber, double balance, string ownerName, string accountType)
    {
        this._accountNumber = accountNumber;
        this._balance = balance;
        this._ownerName = ownerName;
        this.AccountType = accountType;
    }

    public double DepositMoney(double sum)
    {
        this._balance = this._balance + sum;
        return this._balance;
    }    

    public double WithdrawMoney(double sum)
    {
        if(sum< this._balance)
        {
            this._balance = this._balance - sum;
            return this._balance;
        }
        else
        {
            return -1;
        }
    }    

    public void CheckBalance()
    {
        Console.WriteLine("Current balance: {0}",this._balance);
    }

    public virtual (double, double, double) Transfer(Account acc, double sum)
    {
        if(acc == this)
        {
            return (-3,-3,-3);
        }
        else
        {
            if(sum<=this._balance)
            {
                this._balance = this._balance - sum;
                acc._balance = acc._balance + sum;
                return (this._balance, acc._balance, sum);
            }
            else
            {
                return(this._balance,-1,sum);
            }
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Account number: {0} \nOwner name: {1} \nBalance: {2} \nAccount Type: {3}",this._accountNumber, this._ownerName, this._balance, this.AccountType);
    }

    public int CompareTo(object obj)
    {
        Account incomingAccount = obj as Account;
        if(long.Parse(this._accountNumber) < long.Parse(incomingAccount._accountNumber))
        {
            return -1;
        }
        else if(long.Parse(this._accountNumber) > long.Parse(incomingAccount._accountNumber))
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        throw new NotImplementedException();
    }
}