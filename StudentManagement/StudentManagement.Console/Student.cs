namespace StudentManagement.Console
{
    [Serializable]
    public class Student
    {
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }

        public List<StudentGrade> Grades { get; private init; } = new List<StudentGrade>();
        public int Id { get; init; } = Random.Shared.Next(1, 1000);


    }

}
