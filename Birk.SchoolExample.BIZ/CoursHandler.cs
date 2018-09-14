using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Birk.SchoolExample.DAL.EF;

namespace Birk.SchoolExample.BIZ
{
    public class CoursHandler : BaseHandler
    {
        //GET
        /// <summary>
        /// A method that returns all courses in from the database in a list
        /// </summary>
        /// <returns>
        /// Cours List
        /// </returns>
        public List<Cours> GetAllCours()
        {
            return Model.Courses.ToList();
        }

        //ADD
        /// <summary>
        /// A method that adds a cours to the database
        /// </summary>
        /// <param name="cours">The cours to be added</param>
        public void AddCoursToDB(Cours cours)
        {
            if (cours == null || (cours.Department == null && cours.DepartmentID == 0))
            {
                throw new ArgumentNullException();
            }
            else
            {
                Model.Courses.Add(cours);
                Model.SaveChanges();
            }
        }

    }
}
