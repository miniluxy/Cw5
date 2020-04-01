using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Cw5.Models;

namespace Cw5.Services
{
    public interface IStudentsDbService
    {
        public Enrollment GetEnrollment();
        public void AddStudnet(string studies, AddStudent request);
        void PromoteStudents(PromoteStudents promotion);
        public int getMsg();
        void AddStudnet(string studies, string semester);
        void AddStudnet(AddStudent request);
    }

    public class AddStudent
    {
        public string IndexNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Studies { get; set; }
    }

    public class PromoteStudents
    {
        public string studies { get; set; }
        public int semester { get; set; }
    }

    public class Enrollment
    {
        public int IdEnrollment { get; set; }
        public int Semester { get; set; }
        public int IdStudy { get; set; }
        public DateTime StartDate { get; set; }
    }
}
