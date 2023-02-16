using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Acc.BL;

public class StudentCourseWriteDto
{
    const int capacity = 10;
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DOB { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string level { get; set; }
    public List<CourseWriteDto> courseWriteDtos { get; set; } = new List<CourseWriteDto>(capacity);
}
