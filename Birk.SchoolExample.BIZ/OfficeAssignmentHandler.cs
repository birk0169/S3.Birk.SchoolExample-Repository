using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Birk.SchoolExample.DAL.EF;

namespace Birk.SchoolExample.BIZ
{
    public class OfficeAssignmentHandler : BaseHandler
    {
        //GET
        public List<OfficeAssignment> GetAllOfficeAssignments()
        {
            return Model.OfficeAssignments.ToList();
        }
    }
}
