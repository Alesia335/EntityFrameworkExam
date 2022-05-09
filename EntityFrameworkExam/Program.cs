// See https://aka.ms/new-console-template for more information
using EntityFrameworkExam;

Console.WriteLine("Hello, World!");

/*DB context = new DB();
var department = new Department() { Name = "Department 1" };
var students = new List<Student>
            {
                new Student { Name = "Saulius" },
                new Student { Name = "Tomas"},
                new Student { Name = "Arturas" },
                new Student { Name = "Gytis"},
                new Student { Name = "Simona"},
                new Student { Name = "Agne"},
                new Student { Name = "Laura"},
            };
var lectures = new List<Lecture>
            {
                new Lecture { Name = "Chemistry"},
                new Lecture { Name = "Microeconomics"},
                new Lecture { Name = "Calculus" },
                new Lecture { Name = "Trigonometry" },
                new Lecture { Name = "Composition" },
                new Lecture { Name = "Literature" }
            };
department.Lectures.AddRange(lectures);
department.Students.AddRange(students);
context.Departments.AddRange(department);
context.SaveChanges();*/

Repository Repository = new Repository();
//1
/*Repository.CreateDepartment(new Department() { Name = "Department 2" }, new List<Student> { new Student { Name = "Emilis" }, new Student { Name = "Lina" } });*/

//2

/*var lectures = new List<Lecture>();
lectures.Add(new Lecture() { Name = "Mathematics" });
lectures.Add(new Lecture() { Name = "Informatics" });
lectures.Add(new Lecture() { Name = "Physics" });
Repository.AddStudensLecturesToDepartment<Lecture>(2, lectures);*/

/*var students = new List<Student>();
students.Add(new Student() { Name = "Alesia" });
students.Add(new Student() { Name = "Timur" });
students.Add(new Student() { Name = "Maksim" });
Repository.AddStudensLecturesToDepartment<Student>(1, students);*/


//3
/*Repository.CreateLecture(new Lecture() { Name = "Engineering" }, 1);*/

//4
/*Repository.CreateStudent(new Student() { Name = "Aleksandra" }, 1);*/

//5
/*Repository.MoveStudentToAnotherDepartament(13, 2);*/

//6
/*Repository.ShowDepartmentStud(2);*/

//7
/*Repository.ShowDepartmentLectures(1);*/

/*//8
Repository.ShowStudentLectures(13);*/

