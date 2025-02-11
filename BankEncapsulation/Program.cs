using System.Collections.Concurrent;
using System.Diagnostics;


namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            
            // ar currentBalance = account.GetBalance();
            
            Console.WriteLine("Welcome to Thief Bank Of America!");
            Console.WriteLine("-----------------------------------------");

            while (true)
            {
                Console.WriteLine("\nPlease select an option");
                Console.WriteLine("1 Deposit Money");
                Console.WriteLine("2 Get Balance");
                Console.WriteLine("3 Exit");

                int option;
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the amount you want to deposit: ");

                        double amount;

                        if (!double.TryParse(Console.ReadLine(), out amount))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount: ");
                            continue;
                        }
                        
                        account.Deposit(amount);
                        Console.WriteLine("Deposit Successful");
                        break;
                    case 2:
                        Console.WriteLine($"Current balance: ${account.GetBalance()}");
                        break;
                    case 3: Console.WriteLine("Thank you for using Thief Bank of America!");
                        return;
                    default: Console.WriteLine("Invalid input. Please enter a valid option. ");
                        break;
                        
                        
                        
                        
                        
                }
                    
            }
            
            //account.Deposit(200);
            
            //currentBalance = account.GetBalance();
            
            //Console.WriteLine(currentBalance);
        }
    }
}
