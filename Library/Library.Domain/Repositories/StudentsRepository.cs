using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Data.Enums;
using Library.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain.Repositories
{
    public class StudentsRepository
    {
        private readonly LibraryContext _context;

        public StudentsRepository(LibraryContext context)
        {
            _context = context;
        }

        public ICollection<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(string id)
        {
            return _context.Students.Include(student => student.BookBorrows)
                .FirstOrDefault(student => student.StudentId == int.Parse(id));
        }

        public ICollection<BookBorrow> GetBookBorrowsByStudentId(int id)
        {
            return _context.BookBorrows.Include(bookBorrow => bookBorrow.Book)
                .Where(student => student.StudentId == id).ToList();
        }

        public bool AddOrEditAStudent(string firstName, string lastName, DateTime dateOfBirth, string gender, string grade, int? studentId)
        {
            firstName = firstName.FirstLettersToUpper(true);
            lastName = lastName.FirstLettersToUpper(true);

            if (firstName == "" || lastName == "" || firstName == "Error" || lastName == "Error")
                return false;

            var genderAsEnum = StudentGender.M;

            if (gender == "F")
                genderAsEnum = StudentGender.F;

            if (!grade.GradeFormat())
                return false;

            if (studentId == null)
            {
                _context.Students.Add(new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    DateOfBirth = dateOfBirth,
                    Gender = genderAsEnum,
                    StudentGrade = grade
                });
                _context.SaveChanges();

                return true;
            }

            _context.Students.Find(studentId).FirstName = firstName;
            _context.Students.Find(studentId).LastName = lastName;
            _context.Students.Find(studentId).DateOfBirth = dateOfBirth;
            _context.Students.Find(studentId).Gender = genderAsEnum;
            _context.Students.Find(studentId).StudentGrade = grade;
            _context.SaveChanges();

            return true;
        }

        public void RemoveAStudent(string studentId)
        {
            _context.Students.Remove(_context.Students.Find(int.Parse(studentId)));
            _context.SaveChanges();
        }
    }
}
