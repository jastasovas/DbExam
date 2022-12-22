

using DbExam;
using DbExam.Entities;

using var context = new DepartmentContext();

//Department dep1 = new Department { Name = "Chemistry" };
//Department dep2 = new Department { Name = "Computer Science" };
//Department dep3 = new Department { Name = "Mathematical Sciences" };
//Department dep4 = new Department { Name = "Physics" };

//-------- 1 -----------
var lec1 = new Lecture {Name = "Informatics"};
var lec2 = new Lecture {Name = "Physics"};
var stud1 = new Student {FirstName = "Vardunas", LastName = "Pavardunas"};
var stud2 = new Student {FirstName = "Vardene", LastName = "Pavardene"};
var dep5 = new Department {Name = "Computer Science", Students = new List<Student> {stud1, stud2 }, Lectures = new List<Lecture> {lec1, lec2 }};
//context.AddRange(dep5);
//context.SaveChanges();
//-------- 2 -----------
