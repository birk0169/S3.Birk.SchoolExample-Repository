using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Birk.SchoolExample.DAL.EF;

namespace Birk.SchoolExample.BIZ
{
    public class DepartmentHandler : BaseHandler
    {
        //GET
        /// <summary>
        /// A method that returns all departments from the database
        /// </summary>
        /// <returns></returns>
        public List<Department> GetAllDepartments()
        {
            return Model.Departments.ToList();
        }
    }
}
