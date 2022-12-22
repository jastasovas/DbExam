

using DbExam;
using DbExam.Entities;

using var context = new DepartmentContext();

Department dep1 = new Department { Name = "Chemistry" };

context.Departments.Add(dep1);
context.SaveChanges();  