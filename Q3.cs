using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ClassesAndObjects
{
    internal class Q3
    {
        public static void Main()
        {
            double rl, phy, che, ca,mat,hin, total,cls,sem;
            double avg;
            string nm, div,branch;

            Console.Write("\n\n");
            Console.Write("Calculate the total, average and division to take marks of five subjects:\n");
            Console.Write("-------------------------------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input the Roll Number of the student :");
            rl = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Name of the Student :");
            nm = Console.ReadLine();

            Console.Write("Input the class  of the student :");
            cls = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Semester of the student :");
            sem = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Input the Name of the Student :");
           // nm = Console.ReadLine();

            Console.Write("Input the Branch of the Student :");
            branch = Console.ReadLine();

            Console.Write("Input  the marks of Physics : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  Chemistry : ");
            che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of Computer Application : ");
            ca = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of Mathematics : ");
            mat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of Hindi : ");
            hin = Convert.ToInt32(Console.ReadLine());

            total = phy + che + ca+mat+hin;
            avg = total / 5;
            if (phy< 35 || che<35 || ca<35 || mat<35 || hin<35)
                div = "Failed";
            
            else
                if (avg < 50 && phy > 35 && che>35 && ca>35 && mat>35 && hin>35)
                div = "Failed";
            else
                div = "Pass";

            Console.Write("\nRoll no of Student : {0}\nName of Student : {1}\nclass  of the studentn : {2}\nSemester  of the studentn : {3}\nBranch  of the student : {4}\n", rl, nm,cls,sem,branch);
            Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Computer Application : {2}\nMarks in Mathematics : {3}\nMarks in Hindi : {4}\n", phy, che, ca,mat,hin);
            Console.Write("Total Marks = {0}\nAverage = {1}\nDivision = {2}\n", total, avg, div);
            Console.ReadLine();
        }
    }
    
}
