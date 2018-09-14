using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Birk.SchoolExample.DAL.EF;

namespace Birk.SchoolExample.BIZ
{
    public class StudentGradeHandler : BaseHandler
    {
        //GET
        /// <summary>
        /// A method that returns all the studentGrades from the database
        /// </summary>
        /// <returns></returns>
        public List<StudentGrade> GetAllStudentGrades()
        {
            return Model.StudentGrades.ToList();
        }
    }
}
