using StudentManagement.Console;



bool menu = true;
var students = new List<Student>();
string name, surname, occupation;
int age;

do
{


    Console.WriteLine("Press 1 to insert student");
    Console.WriteLine("Press 2 to display student info");
    Console.WriteLine("\nChoose Option");
    int option = int.Parse(Console.ReadLine());




    switch (option)
    {
        case 1:
            Console.WriteLine("Enter student name");
            name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty. Please enter your name:");
                name = Console.ReadLine();
            }

            Console.WriteLine("Enter student surname");
            surname = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(surname) || surname.Length > 3)
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
            Console.WriteLine("Succesfully added a student. {0} {1} studies {2}. His id is {3} and he is {4}", student.Name, student.Surname, student.Occupation, student.Id, student.Age);
            students.Add(student);
            break;
        case 2:

            Student[] arrayOfStudents = students.ToArray();
            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                Console.WriteLine(arrayOfStudents[i].Name + " " + arrayOfStudents[i].Surname + " " + "studies" + " " + arrayOfStudents[i].Occupation + " " + "He is " + arrayOfStudents[i].Age + " " + "years old. His id is" + " " + arrayOfStudents[i].Id);
            }
            //foreach (Student studentList in students)
            //{
            //    Console.WriteLine(studentList);
            //}
            break;
        default: break;
    }
    Console.WriteLine("Back to Menu? y/n");
    char c = char.Parse(Console.ReadLine());

    if (c == 'y')
    {
        menu = true;
    }
    else
    {
        menu = false;
    }
} while (menu);

