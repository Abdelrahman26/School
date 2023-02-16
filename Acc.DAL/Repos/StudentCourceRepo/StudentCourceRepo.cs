using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.DAL;

public class StudentCourceRepo : GenericRepo<StudentCources>, IStudentCourceRepo
{
    public StudentCourceRepo(AccContext accContext) : base(accContext)
    {

    }
}
