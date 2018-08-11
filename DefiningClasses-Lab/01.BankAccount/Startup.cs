using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        var accounts = new Dictionary<int, BankAccount>();
        var command = Console.ReadLine().Split();

        while (!command[0].Equals("End"))
        {
            string commandType = command[0];

            switch (commandType)
            {
                case "Create":
                    Create(command, accounts);
                    break;
                case "Deposit":
                    Deposit(command, accounts);
                    break;
                case "Withdraw":
                    Withdraw(command, accounts);
                    break;
                case "Print":
                    Print(command, accounts);
                    break;
            }

            command = Console.ReadLine().Split();
        }
    }

    private static void Create(string[] command, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(command[1]);

        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            BankAccount account = new BankAccount
            {
                Id = id
            };
            accounts.Add(id, account);
        }
    }

    private static void Deposit(string[] command, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(command[1]);

        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            var currentAccount = accounts[int.Parse(command[1])];
            decimal amount = decimal.Parse(command[2]);

            currentAccount.Deposit(amount);
        }
    }

    private static void Withdraw(string[] command, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(command[1]);

        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            var currentAccount = accounts[int.Parse(command[1])];
            decimal amount = decimal.Parse(command[2]);

            if (currentAccount.Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                currentAccount.Withdraw(amount);
            }
        }
    }

    private static void Print(string[] command, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(command[1]);

        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            var currentAccount = accounts[int.Parse(command[1])];

            Console.WriteLine($"Account ID{currentAccount.Id}, balance {currentAccount.Balance:f2}");
        }
    }
}