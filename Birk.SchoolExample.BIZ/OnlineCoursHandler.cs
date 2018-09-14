using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Birk.SchoolExample.DAL.EF;

namespace Birk.SchoolExample.BIZ
{
    public class OnlineCoursHandler : BaseHandler
    {
        /// <summary>
        /// A method that returns all the OnlineCourses from the database
        /// </summary>
        /// <returns></returns>
        public List<OnlineCours> GetAllOnlineCourses()
        {
            return Model.OnlineCourses.ToList();
        }
    }
}
