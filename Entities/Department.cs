using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExam.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Lecture> Lectures { get; set; }

        public Department() { }
     
        public Department(string name, List<Student> students, List<Lecture> lectures)
        {
            Name = name;
            Students = new List<Student>();
            Lectures = new List<Lecture>();
        }   
    }
}
