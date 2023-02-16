using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.DAL;

public class StudentRepo : GenericRepo<Student>, IStudentRepo
{
    private readonly AccContext _accContext;
    public StudentRepo(AccContext accContext) : base(accContext)
    {
        _accContext = accContext;
    }

   
}
