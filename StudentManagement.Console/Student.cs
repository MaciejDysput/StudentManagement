using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_StudentClass
{
    class Student
    {
        public string name { get; set; }
        public string subname { get; set; }
        public string occupation { get; set; }
        public int age { get; set; }
        public double id { get; set; }

        //public Student(string studentName, string studentSubname,string studentOccupation, int studentAge, double studentId)
        //{
        //    name = studentName;
        //    subname = studentSubname;
        //    occupation = studentOccupation;
        //    age = studentAge;
        //    id = studentId;

        //}
        public void GetFullInfo()
        {
            Console.WriteLine("Student name is {0} {1}", name, subname);
            Console.WriteLine("He is studying {0}", occupation);
            Console.WriteLine("He's id is {0}", id);
            Console.WriteLine("He is {0} years old", age);
        }

    }

}
