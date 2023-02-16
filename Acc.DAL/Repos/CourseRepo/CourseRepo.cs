using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.DAL;

public class CourseRepo : GenericRepo<Course>, ICourseRepo
{
    private readonly AccContext _accContext;
    public CourseRepo(AccContext accContext) : base(accContext)
    {
        _accContext = accContext;
    }
        
}
