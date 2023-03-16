using StudentManagement.Console;

List<Student> students = new List<Student>();
students.Add(new Student());
Console.WriteLine("Enter student name");
students[0].Name = Console.ReadLine();
Console.WriteLine("Enter student subname");
students[0].Surname = Console.ReadLine();
Console.WriteLine("What the student is studying");
students[0].Occupation = Console.ReadLine();
Console.WriteLine("Enter student id"); students[0].Id = int.Parse(Console.ReadLine());
Console.WriteLine("How old is student");
students[0].Age = int.Parse(Console.ReadLine());
students[0].GetFullInfo();
Console.ReadLine();
