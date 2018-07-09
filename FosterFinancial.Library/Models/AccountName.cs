using System;

namespace FosterFinancial.Library.Models
{
  public class AccountName : AccountBalance
  {
    public string accountName = string.Empty;
    public string GetAccountName()
    {
      Console.WriteLine("Please enter account name: ");
      accountName = Console.ReadLine();
      return accountName;
    }
  }
}