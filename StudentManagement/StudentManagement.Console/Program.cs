using StudentManagement.Console;
bool menu = false;
do
{


    Console.WriteLine("1 -- Insert new Student\t");
    Console.WriteLine("2 -- Show all students\t");
    Console.WriteLine("Choose");
    int option = int.Parse(Console.ReadLine());
   


    var students = new List<Student>();
    var student = new Student();
    switch (option)
    {
        case 1:
            Console.WriteLine("Enter student name");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter student subname");
            student.Surname = Console.ReadLine();
            Console.WriteLine("What the student is studying");
            student.Occupation = Console.ReadLine();
            Console.WriteLine("Enter student id");
            student.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("How old is student");
            student.Age = int.Parse(Console.ReadLine());
            students.Add(student);
            break;
        case 2:
            foreach (Student studentList in students)
            {
                Console.WriteLine(studentList);
            }
            break;
        default: break;
    }

    Console.WriteLine("{0} {1} studies {2}. His id is {3} and he is {4}", student.Name, student.Surname, student.Occupation, student.Id, student.Age);
    Console.WriteLine("Back to Menu? y/n");
    char c = char.Parse(Console.ReadLine());

    if (c == 'y')
    {
        menu = false;
    }
    else
    {
        menu = true;
    }
} while (!menu);








