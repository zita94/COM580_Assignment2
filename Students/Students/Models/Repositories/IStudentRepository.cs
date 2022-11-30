using System.Collections.Generic;

namespace Students.Models.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student SelectByID (int id);
        void Insert (Student student);
        void Update (Student student);
        void Delete (int id);
        void Save();
    }
}
