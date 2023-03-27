using Newtonsoft.Json;
using StudentManagement.Console;
using System.Text;
using System.Linq;

bool menu = true;
var students = new List<Student>(); //definicja listy studentow
var lecturers = new List<Lecturer>(); //definicja listy wykladowcow         //instancja klasy Subject
string name, surname, occupation;
var subjects = new Subject();

int age, id;
var sum = 0;

//podawanie sciezki pliku json, ktory stanowi baze danych przetrzymywanych obiektow, deserializacja zamienia postac obiektu na wartosc jaka chcemy otrzymac
string filePath = @"C:\Users\macie\source\repos\StudentManagement\file.json";
if (File.Exists(filePath))
{
    Console.WriteLine("The JSON file exists.");
    string readText = File.ReadAllText(filePath);
    students = JsonConvert.DeserializeObject<List<Student>>(readText);
}
else
{
    Console.WriteLine("Json file doesn't exist");
}

do
{
    Console.WriteLine("Press 0 to leave menu");
    Console.WriteLine("Press 1 to insert student");
    Console.WriteLine("Press 2 to display student info");
    Console.WriteLine("Press 3 to save a students list");
    Console.WriteLine("Press 4 to delete a student from students list");
    Console.WriteLine("Press 5 to edit student");
    Console.WriteLine("Press 6 to add a grade to a student");
    Console.WriteLine("Press 7 to check the student's grade average value");
    Console.WriteLine("Press 8 to check the student's who have a 2.0 at the end of the term");
    Console.WriteLine("Press 9 to insert lecturer");
    Console.WriteLine("Press 10 to insert lecturer");
    Console.WriteLine("Press 11 to check the students who has highest average grade value");

    Console.WriteLine("\nChoose Option");
    int option = int.Parse(Console.ReadLine());
    switch (option)
    {

        case 0:
            menu = false;
            break;
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
            subjects.Students.Add(student);
            var zmienna = students.Select(n => $"{n.Name} {n.Surname}").ToArray();
            Console.WriteLine(zmienna);
            Console.WriteLine(students.ToArray());
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
                Console.WriteLine("Creating a new json file");
                File.Create(filePath).Close();
            }
            var studentJson = JsonConvert.SerializeObject(students);
            File.WriteAllText(filePath, studentJson, Encoding.UTF8);

            break;
        case 4:
            Console.Write("Enter the ID of the student to remove: ");
            int studentToDelete = int.Parse(Console.ReadLine());

            Student personToDelete = students.Find(s => s.Id == studentToDelete);
            if (personToDelete != null)
            {
                students.Remove(personToDelete);
                Console.WriteLine($"Student with id: {studentToDelete} is deleted from database");
            }
            else
            {
                Console.WriteLine($"Student with id: {studentToDelete} is not found");
            }
            break;
        case 5:
            Console.WriteLine("Enter the ID of the student to edit his data");
            int editID = int.Parse(Console.ReadLine());
            Student studentToEdit = students.Find(s => s.Id == editID);
            if (studentToEdit != null)
            {
                Console.WriteLine("Enter student name: ");
                string newName = Console.ReadLine();
                studentToEdit.Name = newName;
                Console.WriteLine("Enter student surname: ");
                string newSurname = Console.ReadLine();
                studentToEdit.Surname = newSurname;
                Console.WriteLine("Enter student occupation: ");
                string newOccupation = Console.ReadLine();
                studentToEdit.Occupation = newOccupation;
                Console.WriteLine("Enter student age: ");
                int newAge = int.Parse(Console.ReadLine());
                studentToEdit.Age = newAge;
                editID = studentToEdit.Id;
            }
            else
            {
                Console.WriteLine($"Student with id: {studentToEdit} not found");
            }
            break;

        case 6:
            Console.WriteLine("Enter the ID of student you want to assign a grade");
            double gradeById = double.Parse(Console.ReadLine());
            Student gradeForStudent = students.Find(s => s.Id == gradeById);
            
            if (gradeForStudent != null)
            {
                Console.WriteLine($"Enter a grade you want to assign for {gradeForStudent.Name}");
                int grade = int.Parse(Console.ReadLine());
                gradeForStudent.Grades.Add(new StudentGrade {Grade=grade });
                Console.WriteLine($"{ gradeForStudent.Name} received a {grade}");
                
            }
            else
            {
                Console.WriteLine($"Student with id:{gradeForStudent} not found ");
            }
            
            


                break;

        case 7:
            
            Console.WriteLine("Enter the ID of student you want to check his average grade's value");
            
            gradeById = double.Parse(Console.ReadLine());
            gradeForStudent = students.Find(s => s.Id == gradeById);

            //if (gradeForStudent != null)
            //{
            //    double average = gradeForStudent.Grades.Average(g => g.Grade);
            //    Console.WriteLine($"{gradeForStudent.Name} has a {average}");
            //}
            //else
            //{
            //    Console.WriteLine($"Student with id:{gradeForStudent} not found ");
            //}
            if (gradeForStudent != null)
            {
                foreach (var studentsGradeList in gradeForStudent.Grades)
                {
                    sum += studentsGradeList.Grade;
                }
                Console.WriteLine($"{gradeForStudent.Name} has {sum / gradeForStudent.Grades.Count()} average grade value");
            }
            else
            {
                Console.WriteLine($"Student with id:{gradeById} not found ");
            }
            



            break;

        case 8:
            
            foreach (var AverageGrade in students)
            {
                double average = AverageGrade.Grades.Average(g => g.Grade);

                if (average < 3.0)
                {
                    Console.WriteLine($"{AverageGrade.Name} is below 3.0 grade average value");
                }
               

            }


            


            break;
        case 9:
            Console.WriteLine("Enter lecturer name");
            name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty. Please enter your name:");
                name = Console.ReadLine();
            }

            Console.WriteLine("Enter lecturer surname");
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
            Console.WriteLine("How old is lecturer");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Incorrect value, Please enter your age:");
            }
            int AgeLecturer = age;
            var lecturer = new Lecturer() { Name = name, Surname = surname, Occupation = occupation, Age = AgeLecturer };
            Console.WriteLine("Succesfully added a lecturer. {0} {1} studies {2}. He is {4} years old\n", lecturer.Name, lecturer.Surname, lecturer.Occupation, lecturer.Age);
            lecturers.Add(lecturer);
            
       
            break;
        case 10:    
            string StartDate;
            Console.WriteLine("Input Start Date");
            StartDate = Console.ReadLine();
            DateTime date = DateTime.Parse(StartDate);
            Console.WriteLine("Today's date is: {0:dd/MM/yyyy}", date);
            break;
        case 11:
            Console.WriteLine("The most talented students in class are:");
            var topTwoStudents = students.OrderByDescending(a => a.Grades.Average(g => g.Grade)).Take(2);
            foreach (var maxStudent in topTwoStudents)
            {
                Console.WriteLine(maxStudent.Name);
            }
            break;
        default:
            break;
    }
} while (menu);