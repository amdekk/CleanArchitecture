using CLeanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLeanArch.Domain.Interface
{
   public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
