using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.DAL;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DOB { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string level { get; set; }
    public IEnumerable<StudentCources> StudentCources { get; set; } = new HashSet<StudentCources>();

}
