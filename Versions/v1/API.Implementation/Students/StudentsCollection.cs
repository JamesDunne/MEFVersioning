using API.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Implementation.Students
{
    public sealed class StudentsCollection : IStudentsCollection
    {
        public async Task<Student> Get(StudentID id)
        {
            return new Student() { ID = id };
        }
    }
}
