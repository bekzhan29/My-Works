using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class student
    {
        public string name, lastname;
        public double gpa;
        public student()
        {
            name = "";
            lastname = "";
            gpa = 0;
        }
        public student(string na, string ln, double g)
        {
            name = na;
            lastname = ln;
            gpa = g;
        }
        public override string ToString()
        {
            return name + " " + lastname + " " + gpa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student a = new student();
            a.name = Console.ReadLine();
            a.lastname = Console.ReadLine();
            a.gpa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}