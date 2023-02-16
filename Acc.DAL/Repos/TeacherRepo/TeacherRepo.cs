using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.DAL
{
    public class TeacherRepo: GenericRepo<Teacher>, ITeacherRepo
    {
        private readonly AccContext _accContext;
        public TeacherRepo(AccContext accContext) : base(accContext)
        {
            _accContext = accContext;
        }
    }
}
