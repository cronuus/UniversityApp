using UniversityAppp.Models;
namespace UniversityAppp.Services
{
    internal class TeacherService : ITeacherService
    {
        static List<Teacher> _teachers = new List<Teacher>();

        public void Create(Teacher? teacher)
        {
            if (teacher != null)
                _teachers.Add(teacher);
        }

        public void Delete(Guid id)
        {
            _teachers.RemoveAll(x => x.Id == id);
        }

        public Teacher? Get(Guid id)
            => _teachers.FirstOrDefault(x => x.Id == id);

        public IEnumerable<Teacher>? GetAll()
            => _teachers;

        public void Update(Teacher? teacher)
        {
            Teacher? currentTeacher = _teachers.FirstOrDefault(s => s.Id == teacher?.Id);
            int index = -1;
            if (currentTeacher != null)
                index = _teachers.IndexOf(currentTeacher);
            if (teacher != null)
                _teachers[index] = teacher;
        }
    }
}
