using Acc.DAL;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.BL;

public class StudentManager : IStudentManager
{
    private readonly IStudentRepo studentRepo;
    private readonly IStudentCourceRepo studentCourceRepo;
    private readonly ICourseRepo courseRepo;
    private readonly ITeacherRepo teacherRepo;
    public IMapper mapper { get; }
    public StudentManager(ITeacherRepo teacherRepo, IStudentRepo studentRepo, IStudentCourceRepo studentCourceRepo,ICourseRepo courseRepo, IMapper mapper)
    {
        this.studentRepo = studentRepo;
        this.courseRepo = courseRepo;
        this.studentCourceRepo = studentCourceRepo;
        this.teacherRepo = teacherRepo;
        this.mapper = mapper;
    }
    public void Add(StudentCourseWriteDto studentcourse)
    {
        var std = mapper.Map<Student>(studentcourse);
        studentRepo.Add(std);
        studentRepo.saveChanges();
        var cources = studentcourse.courseWriteDtos;
        foreach (var cource in cources)
        {
            var stdCrs = mapper.Map<StudentCources>(cource);
            stdCrs.StdId = std.Id;
            studentCourceRepo.Add(stdCrs);
            studentCourceRepo.saveChanges();
        }
    }
}
