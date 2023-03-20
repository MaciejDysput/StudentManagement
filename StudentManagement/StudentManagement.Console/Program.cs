using StudentManagement.Console;

var students = new List<Student>();
string name, surname, occupation;
int age;

Console.WriteLine("Enter student name");
name = Console.ReadLine();
while (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Name cannot be empty. Please enter your name:");
    name = Console.ReadLine();
}

Console.WriteLine("Enter student surname");
surname = Console.ReadLine();
while (string.IsNullOrWhiteSpace(surname))
{
    Console.WriteLine("Surname cannot be empty. Please enter your surname:");
    surname = Console.ReadLine();
}
Console.WriteLine("What the student is studying");
occupation = Console.ReadLine();
while (string.IsNullOrWhiteSpace(occupation))
{
    Console.WriteLine("Surname cannot be empty. Please enter your occupation:");
    occupation = Console.ReadLine();
}
Console.WriteLine("How old is student");
while (!int.TryParse(Console.ReadLine(), out age))
{
    Console.WriteLine("Incorrect value, Please enter your age:");
}
int Age = age;

var student = new Student() { Name = name, Surname = surname, Occupation = occupation, Age = Age };
Console.WriteLine($"Student id is {student.Id}");
Console.WriteLine("Succesfully added a student. {0} {1} studies {2}. His id is {3} and he is {4}\n", student.Name, student.Surname, student.Occupation, student.Id, student.Age);
students.Add(student);







