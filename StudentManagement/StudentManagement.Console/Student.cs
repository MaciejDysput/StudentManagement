namespace StudentManagement.Console
{
    public class Student
    {

        public string Name { get; init; }
        public string Surname { get; init; }
        public string Occupation { get; init; }
        public int Age { get; init; }
        public int Id { get; init; } = Random.Shared.Next(1, 1000);
    }

}
