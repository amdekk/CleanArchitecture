using CleanArch.Infra.Data.Context;
using CLeanArch.Domain.Interface;
using CLeanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseReposity : ICourseRepository
    {
        private readonly UniversityDBContext _ctx;

        public CourseReposity(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
