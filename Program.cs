

using DbExam;
using DbExam.Entities;
using Microsoft.EntityFrameworkCore;

using var context = new DepartmentContext();
Department depp = new Department();

//Department dep1 = new Department { Name = "Chemistry" };
//Department dep2 = new Department { Name = "Computer Science" };
//Department dep3 = new Department { Name = "Mathematical Sciences" };
//Department dep4 = new Department { Name = "Physics" };

//-------- 1 -----------
//var lec1 = new Lecture {Name = "Informatics"};
//var lec2 = new Lecture {Name = "Physics"};
//var stud1 = new Student {FirstName = "Vardunas", LastName = "Pavardunas"};
//var stud2 = new Student {FirstName = "Vardene", LastName = "Pavardene"};
//var dep5 = new Department {Name = "Computer Science", Students = new List<Student> {stud1, stud2 }, Lectures = new List<Lecture> {lec1, lec2 }};
//context.AddRange(dep5);
//context.SaveChanges();

//-------- 2 -----------

//var stud3 = new Student { FirstName = "Jonas", LastName = "Jonaitis" };
//var stud4 = new Student {FirstName = "Janina", LastName = "Janinaite"};
//var lec3 = new Lecture { Name = "Math" };
//var lec4 = new Lecture {Name = "Physics" };

//var depar = context.Departments.Where(x => x.Name == "Computer Science").Include(s => s.Students).Include(l => l.Lectures).First();
//depar.Students.Add(stud3);
//depar.Students.Add(stud4);
//depar.Lectures.Add(lec3);
//depar.Lectures.Add(lec4);
//context.Departments.Update(depar);
//context.SaveChanges();

//-------- 3 -----------

//var lec5 = new Lecture { Name = "Biology" };
//var depar = context.Departments.Where(x => x.Name == "Chemistry").Include(l => l.Lectures).First();
//depar.Lectures.Add(lec5);
//context.Departments.Update(depar);
//context.SaveChanges();

//-------- 4 -----------
//var stud5 = new Student {FirstName = "Petras", LastName = "Petrauskas", DepartmentId = 2};
//context.Students.Add(stud5);    
//context.SaveChanges();  

//-------- 5 -----------

//var student = context.Students.First(x => x.Id == 2);
//student.DepartmentId = 3;
//context.SaveChanges();  

//-------- 6 -----------
//var studentsList = context.Students.Where(x => x.DepartmentId == 5).Select(y => y.FirstName).ToList();
//foreach (var student in studentsList)
//{
//    Console.WriteLine(student);
//}
//-------- 6 -----------
