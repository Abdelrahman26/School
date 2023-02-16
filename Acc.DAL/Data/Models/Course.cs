using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.DAL;

public class Course
{

    public int Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<StudentCources> StudentCources { get; set; } = new HashSet<StudentCources>();
    //public IEnumerable<Teacher> Teachers{ get; set; } = new HashSet<Teacher>();
}
