using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignments_Collections
{
    internal class Q4
    {

        public static void Main()
        {
            ArrayList Student = new ArrayList();
            Student.Add("Sumit");
            Student.Add("Rohan");
            Student.Add("Anunay");
            Student.Add("Pandey");
            Student.Add("Pandit");
            Console.Write("List: ");
            foreach (string i in Student)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Sorted in decending order List: ");
            Student.Sort();
            Student.Reverse();
            foreach (string i in Student)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

    }

       
    
}
