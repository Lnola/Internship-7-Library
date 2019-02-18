using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Enums;

namespace Library.Data.Entities.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public StudentGender Gender { get; set; }
        public string StudentGrade { get; set; }
        public ICollection<BookBorrow> BookBorrows { get; set; }
    }
}