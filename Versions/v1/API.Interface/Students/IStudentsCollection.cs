using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Students
{
    public interface IStudentsCollection
    {
        Task<Student> Get(StudentID id);
    }
}
