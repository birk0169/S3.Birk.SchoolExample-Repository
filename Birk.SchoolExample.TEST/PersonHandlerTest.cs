using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Birk.SchoolExample.DAL.EF;
using Birk.SchoolExample.BIZ;

namespace Birk.SchoolExample.TEST
{
    [TestClass]
    public class PersonHandlerTest
    {
        private PersonHandler pHandler = new PersonHandler();



        /// <summary>
        /// A method that checks that a ArgumentNullException is thrown when the GetStudentAverageGrade method is called with a null input.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetStudentAverageGrade_Null_ArgumentNullException()
        {
            pHandler.GetStudentAverageGrade(null);
        }

        //[TestMethod]
        //[]
    }
}
