﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birk.SchoolExample.DAL.EF
{
    /// <summary>
    /// A Partial class that contains additional functions to the autogenerated person class.
    /// </summary>
    public partial class Person
    {
        /// <summary>
        /// A constructor for the person class
        /// </summary>
        /// <param name="firstName">The persons first name</param>
        /// <param name="lastName">The persons last name</param>
        /// <param name="isStudent">Is the person a student? Otherwise the person is an instructor</param>
        /// <param name="date">The time the person was either enrolled or hired</param>
        public Person(string firstName, string lastName, bool isStudent, DateTime? date)
        {
            FirstName = firstName;
            LastName = lastName;
            if (isStudent == true)
            {
                Discriminator = "Student";
                EnrollmentDate = date;
            }
            else
            {
                Discriminator = "Instructor";
                HireDate = date;
            }
            StudentGrades = new HashSet<StudentGrade>();
            Courses = new HashSet<Cours>();
        }

        /// <summary>
        /// A property that holds the full name of the person.
        /// </summary>
        public string FullName { get { return FirstName + " " + LastName; } }

    }
}
