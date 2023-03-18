using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Console
{
    [Serializable]
    public class Student
    {
        
        public string Name { get; init; }
        public string Surname { get; init; }
        public string Occupation { get; init; }
        public int Age { get; init; }
        public double Id { get; init; } = Math.Round(Random.Shared.NextDouble() * 10);

        

        //public string GetFullInfo()
        //{

        //    return $"Student name is {Name} {Surname}." +
        //        $"He studies {Occupation}" +
        //        $" His id is {Id}" +
        //        $"And he is {Age} years old";
        //}


    }

}
