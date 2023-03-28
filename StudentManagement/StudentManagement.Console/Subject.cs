using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Console
{
    public class Subject
    {
        public string Occupation { get; set; }
        public Lecturer Lecturer { get; set; }
        public List<Student> Students { get; set; } = new List<Student> { };
    }
}
