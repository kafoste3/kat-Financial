using System;

namespace FosterFinancial.Library.Models
{
  public class Account : AccountName
  {
    public Account()
    {
      accountName = GetAccountName();
      balance = GetBalance();
    }
    public void Deposit(decimal amount)
    {
      balance += amount;
      Console.WriteLine("Account:{0} has a new balance of: ${1}", accountName, balance);
    }

    public void Withdraw(decimal amount)
    {
      balance -= amount;
      Console.WriteLine("Account:{0} has a new balance of: ${1}", accountName, balance);
    }
  }
}