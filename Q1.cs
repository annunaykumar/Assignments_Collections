using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ClassesAndObjects
{
    internal class Q1
    {
        public static void Main()
        {
            double payment, debt;
            int month;
            Console.WriteLine("Please enter the monthly payment");
            payment = Convert.ToDouble(Console.ReadLine());
            month = 0;
            debt = 1000;
            Console.WriteLine("Month:" + month + "Balance:$" + debt + "Total payed:$" + "0.000");

            while (debt > payment)
            {
                debt = debt * 1.015;
                debt = debt - payment;
                Console.WriteLine("Month: " + (month = month + 1) + "   Balance: $" + debt + "Total payed: $" + (payment * month));
            }
            Console.WriteLine("Month: " + (month = month + 1) + "   Balance: $0.0" + "Total payed: $" + (payment * month - debt));
            Console.ReadLine();
        }
    }
}
    

