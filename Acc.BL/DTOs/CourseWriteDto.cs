using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.BL;

public class CourseWriteDto
{
    public int CrsId { get; set; }
    public int Crs_length { get; set; }
    public DateTime StartTime { get; set; }
    public int TeacherId { get; set; }
}
