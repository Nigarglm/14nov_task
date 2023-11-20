using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _14nov_task.DAL;

namespace _14nov_task.Models
{
    internal class StudentService
    {
        private static readonly AppDbContext _context = new AppDbContext();

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
            // _context.Students.Find(id); 
        }

        public void Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            Student studentToDelete = GetById(id);

            if (studentToDelete != null)
            {
                _context.Students.Remove(studentToDelete);
                _context.SaveChanges();
            }
        }
    }

}
