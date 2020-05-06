using System;
using System.Linq;

namespace CSharpAssignment
{

    class Program
    {

        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            Bank bank = new Bank();

            Console.WriteLine("Hello and welcome to the best virtual experience ever.");

            string commandInput = "";

            while (!commandInput.Equals("0"))
            {
                Console.WriteLine("1. Access your bank");
                Console.WriteLine("2. Vending machine");
                Console.WriteLine("0. Exit your virtual experience.");
                
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
                        Console.WriteLine("4. Count money in your pockets");
                        Console.WriteLine("0. Exit from bank");
                        
                        bankInput = Console.ReadLine();
                        
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
                                    Console.WriteLine("Not enough funds.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Fail to enter valid amount.");
                            }
                        }
                        else if (bankInput == "3")
                        {
                            Console.WriteLine("How much would you like to deposit?");
                            int depositInput;
                            if (Int32.TryParse(Console.ReadLine(), out depositInput))
                            {
                                if (bank.Deposit(depositInput))
                                {
                                    Console.WriteLine("Deposit successful");
                                }
                                else
                                {
                                    Console.WriteLine("Something went wrong. Try again.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("You failed to enter a valid number.");
                            }
                        }
                        else if (bankInput == "4")
                        {
                            Console.WriteLine($"You have {bank.MyPocketMoney()} in your pockets");
                        }
                    }
                }
                
                if (commandInput == "2")
                {
                    
                    Console.WriteLine("Welcome to the vending machine!");
                    
                    string machineInput = "";

                    while (!machineInput.Equals("0"))
                    {
                        Console.WriteLine("1. List current stock");
                        Console.WriteLine("2. Buy item");
                        Console.WriteLine("3. My goods");
                        Console.WriteLine("4. Count money in my pockets");
                        Console.WriteLine("0. Exit shop");

                        machineInput = Console.ReadLine();

                        if (machineInput == "1")
                        {
                            foreach (var item in inventory.GoodsAvailable)
                            {
                                Console.WriteLine($"- {item.Key} - costs: {item.Value}");
                            }
                        }
                        else if (machineInput == "2")
                        {
                            Console.WriteLine("What would you like to buy?");
                            
                            var buyInput = Console.ReadLine();
                            int value;
                            inventory.GoodsAvailable.TryGetValue(buyInput, out value);

                            if (inventory.GoodsAvailable.ContainsKey(buyInput))
                            {

                                if (value > bank.MoneyInPocket)
                                {
                                    Console.WriteLine("You don't have enough money, try withdrawing money from the bank.");
                                }
                                else
                                {
                                    inventory.Buy(buyInput);
                                    bank.MoneyInPocket -= value;
                                    Console.WriteLine($"You have bought {buyInput}. Thank you for your purchase.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("We don't have that in stock right now.");
                            }
                        }
                        else if (machineInput == "3")
                        {
                            if (!inventory.MyGoods.Any())
                            {
                                Console.WriteLine("You have no goods at the moment.");
                            }
                            else
                            {
                                Console.WriteLine("You have this in your inventory:");
                                foreach (var item in inventory.MyGoods)
                                {
                                    Console.WriteLine($"- {item}");
                                }
                            }
                        }
                        else if (machineInput == "4")
                        {
                            Console.WriteLine($"You have {bank.MyPocketMoney()} in your pockets");
                        }
                    }
                }
            }
            Console.WriteLine("Bye bye");
        }
    }
}