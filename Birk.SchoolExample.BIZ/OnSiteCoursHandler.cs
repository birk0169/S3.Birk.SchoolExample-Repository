using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Birk.SchoolExample.DAL.EF;

namespace Birk.SchoolExample.BIZ
{
    public class OnSiteCoursHandler : BaseHandler
    {
        /// <summary>
        /// A method that retuns all OnSiteCourses from the database
        /// </summary>
        /// <returns></returns>
        public List<OnSiteCours> GetAllOnSiteCourses()
        {
            return Model.OnSiteCourses.ToList();
        }
    }
}
