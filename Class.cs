using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Collections
{
    internal class Class
    {
        public static void Main()
        {
            ArrayList mylist = new ArrayList();
            mylist.Add("Roll No:"+1);
            mylist.Add("Name:Bill");
            
            mylist.Add("Class:"+6);
            mylist.Add("Subject:Science");
            mylist.Add(" ");

            ArrayList mylist1 = new ArrayList();
            mylist1.Add("Roll No:"+2);
            mylist1.Add("Name:Sam");
            mylist1.Add("Class:"+6);
            mylist1.Add("Subject:Maths");
            mylist1.Add(" ");

            ArrayList mylist2 = new ArrayList();
            mylist2.Add("Roll No:"+3);
            mylist2.Add("Name:Karan");
           
            mylist2.Add("Class:"+7);
            mylist2.Add("Subject:Arts");
            mylist2.Add(" ");

            Console.WriteLine("Details of 1st Student");

            for (int i = 0; i < mylist.Count; i++)
                Console.WriteLine(mylist[i]);

            Console.WriteLine("Details of 2st Student");

            for (int i = 0; i < mylist1.Count; i++)
                Console.WriteLine(mylist1[i]);

            Console.WriteLine("Details of 3st Student");
            for (int i = 0; i < mylist2.Count; i++)
                Console.WriteLine(mylist2[i]);
            Console.ReadLine();






        }
    }
}
