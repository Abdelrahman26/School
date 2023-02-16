using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.DAL;

public class StudentCources
{
    [ForeignKey("Student")]
    public int StdId { get; set; }
    [ForeignKey("Course")]
    public int CrsId { get; set; }
    [ForeignKey("Teacher")]
    public int TeacherId { get; set; }
    public int Crs_length { get; set; }
    public DateTime StartTime { get; set; }
    public Student Student { get; set; }
    public Course Course { get; set; }
    public Teacher Teacher { get; set; }
}
