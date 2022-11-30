using System.Collections.Generic;
using System.Linq;

namespace Students.Models.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private StudentDBContext db = null;

        public StudentRepository() 
        {
            this.db = new StudentDBContext();
        }

        public StudentRepository(StudentDBContext db)
        {
            this.db = db;
        }

        public void Delete(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return db.Students.OrderBy(x => x.Surname).ToList();
        }

        public void Insert(Student student)
        {
            db.Students.Add(student);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public Student SelectByID(int id)
        {
            return db.Students.Find(id);
        }

        public void Update(Student student)
        {
            db.Entry(student).State = System.Data.Entity.EntityState.Modified;
        }
    }
}