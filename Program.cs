using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            {
                char agn;
                do
                {
                    fuctions k = new fuctions();
                    string str=" ";
                    Console.WriteLine("Please Select Any Function.");
                    Console.WriteLine("\nPress D for Deposit an Amount. \nPress W for Withdraw an Amount.");
                    str =(Console.ReadLine());
                    switch (str)
                    {
                        case "D":
                            k.fun1();
                            break;
                        case "W":
                            k.fun2();
                            break;
                        default:
                            Console.WriteLine("Invalid Selection!!!");
                            break;
                    }
                    Console.WriteLine("\nDo you want to continue this program? (y/n)");
                    agn = Convert.ToChar(Console.ReadLine());

                } while (agn == 'y');

                Console.ReadKey();
            }
        }
    }
}
     
