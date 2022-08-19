using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Collections
{
    internal class Q8
    {
        private int employeeID;


        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        private string designation;


        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        private string name;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Q8() { }


        public Q8(int employeeID,string designation, string name)
        {
            this.employeeID = employeeID;
            this.designation = designation;
            this.name = name;

        }

        public override string ToString()
        {
            return string.Format("{0,-20}{1,-20}{2,-20}", EmployeeID, Designation, Name);
        }
        public static void Main()
        {
            List<Q8> employees = new List<Q8>();
            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("1. Add a new employee");
                Console.WriteLine("2. Display all employees");
                Console.WriteLine("3. Delete currently searched employee");
                Console.WriteLine("4. Search a employee");
                Console.WriteLine("5. Exit");
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Q8 newEmployee = new Q8();
                            Console.Write("Enter the EmployeeID: ");
                            newEmployee.EmployeeID = int.Parse(Console.ReadLine());
                            Console.Write("Enter the Employee Designation: ");
                            newEmployee.Designation = Console.ReadLine();
                            Console.Write("Enter the Employee Name: ");
                            newEmployee.Name = Console.ReadLine();
                            employees.Add(newEmployee);
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("All employees");
                            Console.WriteLine(string.Format("{0,-20}{1,-20}{2,-20}", "EmployeeID","Designation","Name"));
                            foreach (Q8 e in employees)
                            {
                                Console.WriteLine(e.ToString());
                            }
                        }
                        break;

                    case 3:
                        {
                            Console.Write("Enter the EmployeeID to delete: ");
                            int employeeID = int.Parse(Console.ReadLine());
                            bool exist = false;
                            foreach (Q8 e in employees)
                            {
                                if (e.EmployeeID == employeeID)
                                {
                                    employees.Remove(e);
                                    exist = true;
                                    break;
                                }
                            }
                            if (!exist)
                            {
                                Console.WriteLine("\nThe EmployeeID does not exist!\n");
                            }
                        }
                        break;

                    case 4:
                        {
                            Console.Write("Enter the EmployeeID No to search: ");
                            int employeeID = int.Parse(Console.ReadLine());
                            bool exist = false;
                            foreach (Q8 e in employees)
                            {
                                if (e.EmployeeID == employeeID)
                                {
                                    Console.WriteLine(string.Format("{0,-20}{1,-20}{2,-20}", "EmployeeID", "Designation","Name"));
                                    Console.WriteLine(e.ToString());
                                    exist = true;
                                }
                            }
                            if (!exist)
                            {
                                Console.WriteLine("\nThe Employee does not exist!\n");
                            }
                        }
                        break;

                    case 5:
                        break;
                    default:
                        Console.WriteLine("Wrong menu item. Try again.");
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
