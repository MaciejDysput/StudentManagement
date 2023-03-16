using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Console
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }
        public double Id { get; set; }


        public string GetFullInfo()
        {
            return $"Student name is {Name} {Surname}." +
                $"He studies {Occupation}" +
                $" His id is {Id}" +
                $"And he is {Age} years old";
        }

    }

}
