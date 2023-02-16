using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.DAL;

public class Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<StudentCources> StudentCources { get; set; } = new HashSet<StudentCources>();

}
