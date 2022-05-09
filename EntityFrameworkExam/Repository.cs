using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkExam
{
    internal class Repository
    {
        //1
        public static void CreateDepartment<T>(Department Department, List<T> Students)
        {

            using var db = new DB();
            var lectures = db.Lectures;
            Department.Lectures.AddRange(lectures);
            Department.Students.AddRange(Students.Cast<Student>().ToList());
            db.Departments.Add(Department);
            db.SaveChanges();

        }
        //2
        public void AddStudensLecturesToDepartment<T>(int DepartmentId, List<T> Add)
        {
            using var db = new DB();

            var department = db.Departments.Where(s => s.Id == DepartmentId).FirstOrDefault();
            if (typeof(T) == typeof(Student))
            {
                department.Students.AddRange(Add.Cast<Student>().ToList());
            }
            if (typeof(T) == typeof(Lecture))
            {
                department.Lectures.AddRange(Add.Cast<Lecture>().ToList());
            }

            db.SaveChanges();

        }
        //3
        public void CreateLecture(Lecture Lecture, int DepartmentId)
        {
            using var db = new DB();
            var department = db.Departments.Where(s => s.Id == DepartmentId).Include(s => s.Lectures).FirstOrDefault();
            department.Lectures.Add(Lecture);
            db.SaveChanges();
        }
        //4
        public void CreateStudent(Student Student, int DepartmentId)
        {
            using var db = new DB();
            var department = db.Departments.Where(s => s.Id == DepartmentId).Include(s => s.Students).Include(s => s.Lectures).FirstOrDefault();
            Student.Lectures.AddRange(department.Lectures);
            department.Students.Add(Student);
            db.SaveChanges();
        }
        //5
        public void MoveStudentToAnotherDepartament(int StudentId, int DepartmentId)
        {
            using var db = new DB();
            var student = db.Students.Where(s => s.Id == StudentId).Include(s => s.Lectures).FirstOrDefault();
            var department = db.Departments.Where(s => s.Id == DepartmentId).Include(s => s.Lectures).FirstOrDefault();
            student.Lectures = department.Lectures;
            student.DepartmentId = DepartmentId;
            db.SaveChanges();

        }
        //6
        public void ShowDepartmentStud(int DepartmentId)
        {
            using var db = new DB();
            var department = db.Departments.Where(s => s.Id == DepartmentId).Include(s => s.Students).ToList();
            foreach (var item in department)
            {

                foreach (Student stud in item.Students)
                {
                    Console.WriteLine($"Department students: {stud.Name}");
                }

            }
        }
        //7
        public void ShowDepartmentLectures(int DepartmentId)
        {
            using var db = new DB();
            var department = db.Departments.Where(s => s.Id == DepartmentId).Include(s => s.Lectures).ToList();
            foreach (var item in department)
            {

                foreach (Lecture lect in item.Lectures)
                {
                    Console.WriteLine($"Department lectures: {lect.Name}");
                }

            }
        }
        //8
        public void ShowStudentLectures(int StudentId)
        {
           
            using var db = new DB();
            var student = db.Students.Where(s => s.Id == StudentId).Include(s => s.Lectures).ToList();
            foreach (var item in student)
            {

                foreach (Lecture lect in item.Lectures)
                {
                    Console.WriteLine($"Student lectures: {lect.Name}");
                }

            }


        }
    }
}
