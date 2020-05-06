using System;
using System.Collections.Generic;

namespace CSharpAssignment
{

    class Program
    {

        enum Commands
        {
            bank,
            inventory,
            history,
            vendingMachine,
            yes,
            no,
            withdraw,
            numberOfCommands
        }
        
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            Bank bank = new Bank();
            
            Console.WriteLine("Hello and welcome to the best virtual experience ever.");
            Console.WriteLine("1. Access your bank");
            Console.WriteLine("2. Vending machine");
            Console.WriteLine("0. Exit your virtual experience.");
            
            string commandInput = "";

            while (!commandInput.Equals("0"))
            {
                commandInput = Console.ReadLine();
                
                if (commandInput == "1")
                {
                    string bankInput = "";
                    Console.WriteLine("Welcome to your personal ATM.");
                    

                    while (!bankInput.Equals("0"))
                    {
                        Console.WriteLine("1. Balance");
                        Console.WriteLine("2. Withdraw");
                        Console.WriteLine("3. Deposit");
                        Console.WriteLine("0. Exit from bank");
                        
                        if (bankInput == "1")
                        {
                            Console.WriteLine($"Your balance is {bank.MyBalance()}");
                        }
                        else if (bankInput == "2")
                        {
                            Console.WriteLine("Type the amount you want to withdraw.");
                            int withdrawInput;
                            if (Int32.TryParse(Console.ReadLine(), out withdrawInput))
                            {
                                if (bank.Withdraw(withdrawInput))
                                {
                                    Console.WriteLine("Withdrawal successful");
                                }
                                else
                                {
                                    Console.WriteLine("Not enough money. Git gud.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Fail to enter valid amount.");
                            }
                        }
                        else if (bankInput == "3")
                        {
                            
                        }
                    }
                }
                
                if (commandInput == "2")
                {
                    Console.WriteLine("Welcome to the vending machine! Type \"goods\" to see what's in stock or \"history\" to see your purchase history.");
                    break;
                }

                Console.WriteLine("Wrong in command, try again.");
            
            }

        }
    }
}