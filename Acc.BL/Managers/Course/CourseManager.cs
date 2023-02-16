using Acc.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.BL;

public class CourseManager : CourseRepo, ICourseManager
{
    public CourseManager(AccContext accContext) : base(accContext)
    {

    }
}
