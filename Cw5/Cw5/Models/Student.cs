﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw5.Models
{
    public class Student
    {
        public int IdStudent { get; set; }
        public string IndexNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int IdEnrollment { get; set; }
        //prop + tabx2
        public string Studies { get; set; }
        public int Semester { get; set; }
        public override string ToString()
        {
            return $"{IdStudent} {FirstName} {LastName} {IndexNumber} {BirthDate} {IdEnrollment} {Studies} {Semester}";
        }
    }
}
