using Acc.DAL;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.BL
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<StudentCourseWriteDto, Student>();
            CreateMap<CourseWriteDto, StudentCources>();
        }
    }
}
