using System;

namespace cs_bank
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        public static void menu()
        {
            Account a1 = new Account();
            a1.setAccNum();
            a1.setAccForeName("Joe");
            a1.setAccSurName("Bloggs");
            a1.setAccBalance(100);

            Console.WriteLine("Hello " + a1.getAccForeName() + " " + a1.getAccSurName());
            Console.WriteLine("Welcome ot the bank");
            Console.WriteLine("");
            Console.WriteLine("Choose Option");
            Console.WriteLine("1. Check Details");
            Console.WriteLine("2. Withdraw Cash");
            Console.WriteLine("3. Deposit Cash");
            Console.WriteLine("4. Change Name");
            Console.WriteLine("5. Exit");

            int option = Convert.ToInt32(Console.ReadLine());

            while (option != 5) 
            {
                if (option == 1)
                {
                    Console.WriteLine("Account Number:" + a1.getAccNum());
                    Console.WriteLine("Forename:" + a1.getAccForeName());
                    Console.WriteLine("Surnname:" + a1.getAccSurName());
                    Console.WriteLine("Balance:" + a1.getAccBalance());
                    break;
                }
                else if (option == 2)
                {
                    Console.WriteLine("How much do you need?");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    a1.withdraw(amount);
                    break;
                }
                else if(option == 3)
                {
                    Console.WriteLine("How much do you need to deposit?");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    a1.deposit(amount);
                    break;
                }
                else if(option == 4)
                {
                    Console.WriteLine("Whats your first name?");
                    String fname = Convert.ToString(Console.ReadLine());
                    a1.setAccForeName(fname);

                    Console.WriteLine("Whats your second name?");
                    String sname = Convert.ToString(Console.ReadLine());
                    a1.setAccForeName(sname);
                    break;
                }
                else if (option != 1 || option != 2 || option != 3 || option != 4)
                {
                    Console.WriteLine("Whats your second name?");
                    break;
                }

            }
        }

    }
}
