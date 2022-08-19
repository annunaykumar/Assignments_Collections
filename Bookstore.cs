using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Collections
{
    internal class Bookstore
    {
        public static void Main()
        {
            
            Hashtable Mylist = new Hashtable();

            Mylist.Add(001, "Harry Potter");
            Mylist.Add(002, "Game Of Thrones");
            Mylist.Add(003, "Scared Games");
            Mylist.Add(004, "Assain Creed");
            Mylist.Add(005, "Loards of the Ring");
            Mylist.Add(006, "Dark Nights");
            Mylist.Add(007, "Mahabharat");

            if (Mylist.ContainsValue("Dark Nights"))
            {
                Console.WriteLine("This book name is already in the list");
            }
            else
            {
                Mylist.Add(008, "Ramayan");
            }
            // Get a collection of the keys.
            ICollection key = Mylist.Keys;

            foreach (DictionaryEntry kvp in Mylist)
                Console.WriteLine("Book ID: {0}, Book Name: {1}", kvp.Key, kvp.Value);
            
            Console.ReadKey();
        }
    }
}
