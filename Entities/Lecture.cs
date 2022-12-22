﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExam.Entities
{
    public class Lecture
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public List<Department> Departments { get; set; } 
    }
}
