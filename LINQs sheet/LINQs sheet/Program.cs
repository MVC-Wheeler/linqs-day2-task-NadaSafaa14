using System.Collections.Generic;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace LINQs_sheet
{
    internal class Program
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Department { get; set; }
            public double GPA { get; set; }
        }
        public class Course
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public int Credits { get; set; }
        }
        public class Enrollment
        {
            public int StudentId { get; set; }
            public int CourseId { get; set; }
        }

        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "Ahmed Ali", Age = 21, Department = "CS", GPA = 3.6 },
                new Student { Id = 2, Name = "Sara Mohamed", Age = 20, Department = "IT", GPA = 3.2 },
                new Student { Id = 3, Name = "Omar Hassan", Age = 22, Department = "CS", GPA = 2.8 },
                new Student { Id = 4, Name = "Mona Adel", Age = 19, Department = "IS", GPA = 3.9 },
                new Student { Id = 5, Name = "Youssef Kamal", Age = 23, Department = "CS", GPA = 2.4 },
                new Student { Id = 6, Name = "Aya Mostafa", Age = 21, Department = "IT", GPA = 3.5 },
                new Student { Id = 7, Name = "Hassan Mahmoud", Age = 24, Department = "IS", GPA = 1.9 },
                new Student { Id = 8, Name = "Nada Fathy", Age = 20, Department = "CS", GPA = 3.1},
                new Student { Id = 9, Name = "Ali Samir", Age = 18, Department = "IT", GPA = 2.6 },
                new Student { Id = 10, Name = "Reem Tarek", Age = 22, Department = "IS", GPA = 3.7 },
                new Student { Id = 11, Name = "Amr Nabil", Age = 21, Department = "CS", GPA = 4.0 },
                new Student { Id = 12, Name = "Laila Ashraf", Age = 19, Department = "IT", GPA = 2.2 }
            };

            var courses = new List<Course>()
            {
                new Course { Id = 1, Title = "C# Fundamentals", Credits = 3 },
                new Course { Id = 2, Title = "OOP", Credits = 4 },
                new Course { Id = 3, Title = "Databases", Credits = 3 },
                new Course { Id = 4, Title = "ASP.NET MVC", Credits = 4 },
                new Course { Id = 5, Title = "LINQ Deep Dive", Credits = 2 }
            };

            var enrollments = new List<Enrollment>
            {
                new Enrollment { StudentId = 1, CourseId = 1 },
                new Enrollment { StudentId = 1, CourseId = 2 },

                new Enrollment { StudentId = 2, CourseId = 1 },
                new Enrollment { StudentId = 2, CourseId = 3 },

                new Enrollment { StudentId = 3, CourseId = 2 },

                new Enrollment { StudentId = 4, CourseId = 4 },
                new Enrollment { StudentId = 4, CourseId = 5 },

                new Enrollment { StudentId = 6, CourseId = 3 },
                new Enrollment { StudentId = 6, CourseId = 4 },

                new Enrollment { StudentId = 8, CourseId = 1 },

                new Enrollment { StudentId = 10, CourseId = 2 },
                new Enrollment { StudentId = 10, CourseId = 3 },

                new Enrollment { StudentId = 11, CourseId = 5 }
            };
            // Q1
            //var names = students.Select(s => s.Name).ToList();
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            // Q2
            //var a = students.Select(x => new
            //{
            //    x.Name,
            //    x.GPA
            //});
            //foreach (var item in a)
            //{
            //    Console.WriteLine($"Name: {item.Name}, GPA: {item.GPA}");
            //}

            // Q3
            ////var gpa = students.Where(s => s.GPA > 3.8).ToList();
            ////if (gpa.Count() != 0)
            ////{
            ////    Console.WriteLine("True");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("False");
            ////}

            //var gpa = students.Any(s => s.GPA > 3.8);
            //Console.WriteLine(gpa);

            // Q4
            //var age = students.All(s => s.Age > 18);
            //Console.WriteLine(age);

            // Level 1 : Q1
            //var s = students.Where(s => s.Age > 20).ToList();
            //foreach (var item in s)
            //{
            //    Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
            //}

            //--------------------------------------------------

            // Level 1 : Q2
            //var s = students.Where(s => s.Department == "CS").ToList();
            //foreach (var student in s)
            //{
            //    Console.WriteLine(student.Name);
            //}

            // Level 1 : Q3
            //var s = students.Select(x => new { x.Name , x.Department }).ToList();
            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}

            // Level 1 : Q4
            //var s = students.OrderBy(x => x.GPA);
            //foreach (var student in s)
            //{
            //    Console.WriteLine(student.Name);
            //}

            // Level 1 : Q5
            //var s = students.OrderByDescending(x => x.GPA).ThenBy(x => x.Name);
            //foreach (var student in s)
            //{
            //    Console.WriteLine(student.Name);
            //}

            // Level 1 : Q6
            //var s = students.OrderByDescending(x => x.GPA).Take(5);
            //foreach (var student in s)
            //{
            //    Console.WriteLine($"Name : {student.Name} , Gpa : {student.GPA}");
            //}

            // Level 1 : Q7
            //var s = students.Any(x => x.GPA < 2.0);
            //Console.WriteLine(s);

            // Level 1 : Q8
            //var s = students.All(x => x.GPA >= 2.0);
            //Console.WriteLine(s);

            // Level 1 : Q9
            //var count = students.Count();
            //Console.WriteLine(count);

            // Level 1 : Q10
            //var s = students.Where(x => x.Name.Length > 5).ToList();
            //foreach (var student in s)
            //{
            //    Console.WriteLine(student.Name);
            //}

            //-------------------------------------------------

            // Level 2 : Q1
            //var count = students.Count();
            //Console.WriteLine(count);

            // Level 2 : Q2
            //var max = students.Max(x => x.GPA);
            //Console.WriteLine(max);

            // Level 2 : Q3
            //var min = students.Min(x => x.GPA);
            //Console.WriteLine(min);

            // Level 2 : Q4
            //var avg = students.Average(x => x.GPA);
            //Console.WriteLine(avg);

            // Level 2 : Q5
            //var avg = students.Where(x => x.Department == "CS").Average(x => x.GPA);
            //Console.WriteLine(avg);

            // Level 2 : Q6
            //var sum = students.Sum(x => x.GPA);
            //Console.WriteLine(sum);

            // Level 2 : Q7
            //var avg = students.Average(x => x.GPA);
            //var s = students.Where(x => x.GPA > avg).Count();
            //Console.WriteLine(s);

            // Level 2 : Q8
            //var top_3 = students.OrderByDescending(x => x.GPA).Take(3).ToList();
            //var avg = top_3.Average(x => x.GPA);
            //Console.WriteLine(avg);

            // Level 2 : Q9
            //var skip_2 = students.OrderBy(x => x.GPA).Skip(2).ToList();
            //var avg = skip_2.Average(x => x.GPA);
            //Console.WriteLine(avg);

            // Level 2 : Q10
            //var highst_gpa = students.Max(x => x.GPA);
            //foreach (var student in students)
            //{
            //    if (student.GPA == highst_gpa)
            //    {
            //        Console.WriteLine($"Name: {student.Name}, GPA: {student.GPA}");
            //    }
            //}

            // Level 2 : Q11
            //var total = students.Count;
            //Console.WriteLine(total > 20);

            // Level 3 : Q1
            //var dep = students.GroupBy(x => x.Department).ToList();
            //foreach (var group in dep)
            //{
            //    Console.WriteLine($"Department : {group.Key} , Count : {group.Count()}");
            //}

            // Level 3 : Q2
            //var dep = students.GroupBy(x => x.Department).ToList();
            //foreach (var group in dep)
            //{
            //    Console.WriteLine($"Department : {group.Key} , Average GPA : {group.Average(x => x.GPA)}");
            //}

            // Level 3 : Q3
            //var grouped = students.GroupBy(x =>
            //{
            //    if (x.GPA < 2.5)
            //        return "Low";
            //    else if (x.GPA <= 3.5)
            //        return "Medium";
            //    else
            //        return "High";
            //}).ToList();

            //foreach (var group in grouped)
            //{
            //    Console.WriteLine($"{group.Key} GPA :");
            //    foreach (var student in group)
            //    {
            //        Console.WriteLine($"    Name : {student.Name} , GPA : {student.GPA}");
            //    }
            //}

            // Level 3 : Q4
            //var query = enrollments
            //    .Join(students,
            //          e => e.StudentId,
            //          s => s.Id,
            //          (e, s) => new { e, s })
            //    .Join(courses,
            //          es => es.e.CourseId,
            //          c => c.Id,
            //          (es, c) => new
            //          {
            //              StudentName = es.s.Name,
            //              CourseTitle = c.Title
            //          });

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Student Name : {item.StudentName} - Course Title : {item.CourseTitle}");
            //}

        }
    }
}