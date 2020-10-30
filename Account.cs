using System;
using System.Collections.Generic;
using System.Text;

namespace cs_bank
{
    class Account
    {
        private int accNum;
        private String accForeName;
        private String accSurName;
        private double accBalance;

        //Constructor
        public Account()
        {
            
        }

        //getters
        public int getAccNum()
        {
            return accNum;
        }
        public String getAccForeName()
        {
            return accForeName; 
        }
        public String getAccSurName()
        {
            return accSurName;
        }
        public double getAccBalance()
        {
            return accBalance;
        }

        //setters 
        public void setAccNum()
        {
            Random random = new Random();
            int accNum = random.Next(1, 10000);
            this.accNum = accNum;
        }
        public void setAccForeName(String accForeName)
        {
            this.accForeName = accForeName;
        }
        public void setAccSurName(String accSurName)
        {
            this.accSurName = accSurName;
        }
        public void setAccBalance(double accBalance)
        {
            this.accBalance = accBalance;
        } 

        //withdraw money
        public void withdraw(double amount)
        {
            double newBalance = this.accBalance - amount; 
            if (newBalance < 0)
            {
                Console.WriteLine("INSUFFICIENT FUNDS");
                Console.WriteLine("You balance is " + this.accBalance);
            }
            else
            {
                this.accBalance = newBalance;
            }
        }

        //deposit money
        public void deposit(double amount)
        {
            this.accBalance = this.accBalance + amount; 
        }
    }
}
