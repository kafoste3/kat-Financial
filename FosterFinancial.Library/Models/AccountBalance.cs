using System;

namespace FosterFinancial.Library.Models
{
  public class AccountBalance
  {
    public decimal balance = 0;
    public decimal GetBalance()
    {
      Console.WriteLine("Please enter balance: ");
      balance = decimal.Parse(Console.ReadLine());
      return balance;
    }
  }
}