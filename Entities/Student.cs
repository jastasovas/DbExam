using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExam.Entities
{
    public class Student
    {
        public int Id { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }   
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public Student() { }
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }   
    }
}
