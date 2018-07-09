using System;
using System.Collections.Generic;
using FosterFinancial.Library.Models;

namespace FosterFinancial.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank();
        }

        private static List<Account> _bankaccount = new List<Account>();

        private static void Bank()
        {
          var exit = false;
          string user = "";
          string input = string.Empty;
          
          
          System.Console.WriteLine("Please enter your ID: ");
          user = Console.ReadLine();
          System.Console.WriteLine("Welcome to Foster Financial, " + user);

          do
          {
            System.Console.WriteLine("[1] Create Account | [2] View Account | [3] Deposit | [4] Withdraw | [5] Transfer | [6] Delete | [7] Exit Foster Financial");
            Console.Write("Enter desired choice: ");
            input = Console.ReadLine();

            switch(input)
            {
              case "1":
                CreateAccount(new Account());
                break;
              case "2":
                ViewAccount();
                break;
              case "3":
                DepositMoney();
                break;
              case "4":
                WithdrawMoney();
                break;
              case "5":
                TransferMoney();
                break;
              case "6":
                DeleteAccount();
                break;
              case "7":
                exit = true;
                break;
            } 
          } while(!exit);
        }

    private static void DeleteAccount()
    {
      Console.WriteLine("Please enter account name you wish to delete: ");
      var d = Console.ReadLine();

      int i = _bankaccount.FindIndex(a => a.accountName == d);
      _bankaccount.RemoveAt(i);
    }

    private static void TransferMoney()
    {
      Console.WriteLine("Please enter account name you wish to withdraw from: ");
      var a1 = Console.ReadLine();
      Console.WriteLine("Please enter account name you wish to deposit to: ");
      var a2 = Console.ReadLine();
      Console.WriteLine("Please enter amount: ");
      decimal amount = decimal.Parse(Console.ReadLine());

      int i1 = _bankaccount.FindIndex(a => a.accountName == a1);
      int i2 = _bankaccount.FindIndex(a => a.accountName == a2);
      _bankaccount[i1].Withdraw(amount);
      _bankaccount[i2].Deposit(amount);
    }

    private static void WithdrawMoney()
    {
      Console.WriteLine("Please enter account name you wish to withdraw from: ");
      var a1 = Console.ReadLine();
      Console.WriteLine("Please enter withdrawal amount: ");
      decimal amount = decimal.Parse(Console.ReadLine());
      
      int i = _bankaccount.FindIndex(a => a.accountName == a1);
      _bankaccount[i].Withdraw(amount);
    }

    private static void DepositMoney()
    {
      Console.WriteLine("Please enter account name you wish to deposit to: ");
      var a1 = Console.ReadLine();
      Console.WriteLine("Please enter deposit amount: ");
      decimal amount = decimal.Parse(Console.ReadLine());
      
      int i = _bankaccount.FindIndex(a => a.accountName == a1);
      _bankaccount[i].Deposit(amount);
    }

    private static void ViewAccount()
    {
      foreach(var Active in _bankaccount)
      {
        Console.WriteLine("Account: {0} with balance of: {1}", Active.accountName, Active.balance);
      }
    }

    private static void CreateAccount(Account Account)
      {
        _bankaccount.Add(Account);
      }

    }
}
