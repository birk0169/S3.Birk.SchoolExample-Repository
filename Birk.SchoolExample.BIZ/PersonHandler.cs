using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Birk.SchoolExample.DAL.EF;

namespace Birk.SchoolExample.BIZ
{
    public class PersonHandler : BaseHandler
    {
        //GET
        /// <summary>
        /// A method that returns all the Persons from the database.
        /// </summary>
        /// <returns></returns>
        public List<Person> GetAllPersons()
        {
            return Model.Persons.ToList();
        }

        public List<Person> GetAllStudents()
        {
            return Model.Persons.Where(x => x.Discriminator == "Student").ToList();
        }

        public List<Person> GetAllInstructors()
        {
            return Model.Persons.Where(x => x.Discriminator == "Instructor").ToList();
        }

        /// <summary>
        /// Gets the total number of persons from the database.
        /// </summary>
        /// <returns>Number of persons in int</returns>
        public int GetNumberOfPersonsTotal()
        {
            return GetAllPersons().Count();
        }

        /// <summary>
        /// Gets the total number of students from the database.
        /// </summary>
        /// <returns>Number of persons with the Discriminator of Student in int</returns>
        public int GetNumberOfStudents()
        {
            return GetAllStudents().Count();
        }

        /// <summary>
        /// Gets the total number of instructors from the database.
        /// </summary>
        /// <returns>Number of persons with the Discriminator of Instructor in int</returns>
        public int GetNumberOfInstructors()
        {
            return GetAllInstructors().Count();
        }

        public decimal GetStudentAverageGrade(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException();
            }
            else if (person.StudentGrades == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                return person.StudentGrades.Select(x => x.Grade).Average().GetValueOrDefault();
            }
        }

        //public decimal GetStudentCoursGrade(Person person)
        //{
        //    return
        //}

        //ADD
        /// <summary>
        /// Adds a person to the database.
        /// </summary>
        /// <param name="person"></param>
        public void AddPersonToDB(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                Model.Persons.Add(person);
                Model.SaveChanges();
            }
        }
    }
}
