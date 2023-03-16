using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student());
            Console.WriteLine("Enter student name");
            students[0].name = Console.ReadLine();
            Console.WriteLine("Enter student subname");
            students[0].subname = Console.ReadLine();
            Console.WriteLine("What the student is studying");
            students[0].occupation = Console.ReadLine();
            Console.WriteLine("Enter student id");
            students[0].id = int.Parse(Console.ReadLine());
            Console.WriteLine("How old is student");
            students[0].age = int.Parse(Console.ReadLine());
            students[0].GetFullInfo();
            Console.ReadLine();
        }
    }
}
