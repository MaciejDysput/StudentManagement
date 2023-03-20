using Newtonsoft.Json;
using StudentManagement.Console;
using System.Text;



bool menu = true;
var students = new List<Student>();
string name, surname, occupation;
int age, id;



do
{

    string filePath = @"C:\Users\macie\source\repos\StudentManagement\file2.json";
    var studentJson = JsonConvert.SerializeObject(students);
    if (File.Exists(filePath))
    {
        Console.WriteLine("The JSON file exists.");

    }
    else
    {
        Console.WriteLine("Json file doesn't exist");

    }
    Console.WriteLine("Press 1 to insert student");
    Console.WriteLine("Press 2 to display student info");
    Console.WriteLine("Press 3 to create a students list data");
    Console.WriteLine("Press 4 to check a students list");

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




            Console.WriteLine(studentJson);


            break;
        case 2:

            Student[] arrayOfStudents = students.ToArray();
            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                Console.WriteLine(arrayOfStudents[i].Name + " " + arrayOfStudents[i].Surname + " " + "studies" + " " + arrayOfStudents[i].Occupation + " " + "He is " + arrayOfStudents[i].Age + " " + "years old. His id is" + " " + arrayOfStudents[i].Id);

            }


            break;
        case 3:
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Creating a new json file...");
                File.Create(filePath).Close();

            }
            break;
        case 4:

            File.WriteAllText(filePath, studentJson, Encoding.UTF8);
            string readText = File.ReadAllText(filePath);
            Console.WriteLine(readText);
            students = JsonConvert.DeserializeObject<List<Student>>(readText);
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