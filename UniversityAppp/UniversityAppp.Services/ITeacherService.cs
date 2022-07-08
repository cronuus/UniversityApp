using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityAppp.Models;

namespace UniversityAppp.Services
{
    public interface ITeacherService
    {
        IEnumerable<Teacher>? GetAll();
        Teacher? Get(Guid id);
        void Create(Teacher? student);
        void Update(Teacher? student);
        void Delete(Guid id);
    }
}
