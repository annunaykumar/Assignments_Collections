using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ClassesAndObjects
{
    class Account
    {
       // public static void Main()
        //{
           // class bank
       // {
            private double balance = 100000;


            public double bal
            {
                get { return balance; }
                set { balance = value; }
            }
        }
        class fuctions
        {
            Account i = new Account();
            string name;
            int account;
            double withdraw, dep, total;

            public void fun1()
            {
                Console.WriteLine("Enter Name of the depositor :");
                name = Console.ReadLine();
                Console.WriteLine("Enter Account Number  :");
                account = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Deposit Amount :");
                dep = Convert.ToDouble(Console.ReadLine());
                total = i.bal + dep;

                Console.WriteLine("------------------------------\n");
                Console.WriteLine("Name of the depositor : " + name);
                Console.WriteLine("Account Number: " + account);
                Console.WriteLine("Total Balance amount in the account  : " + total);

            }
            public void fun2()
            {
                Console.WriteLine("Enter Account Name :");
                name = Console.ReadLine();
                Console.WriteLine("Enter Account Number  :");
                account = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Withdraw Amount :");
                withdraw = Convert.ToDouble(Console.ReadLine());
                if (withdraw <= i.bal)
                {
                    total = i.bal - withdraw;
                    Console.WriteLine("------------------------------\n");
                    Console.WriteLine("Account Name : " + name);
                    Console.WriteLine("Account Number: " + account);
                    Console.WriteLine("After Withdraw Amount balnace is : " + total);
                }
                else
                    Console.WriteLine("\n\nWithdraw Ammount does not Exist your Account.");
            }

        }
    
 }


