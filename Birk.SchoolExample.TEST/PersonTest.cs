using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Birk.SchoolExample.DAL.EF;
using Birk.SchoolExample.BIZ;

namespace Birk.SchoolExample.TEST
{
    [TestClass]
    public class PersonTest
    {

        /// <summary>
        /// A test that validates whether a object of the Person class can be created without causing an exception.
        /// </summary>
        [TestMethod]
        public void CanCreatePersonObject()
        {
            bool failed = false;
            try
            {
                Person person = new Person();
            }
            catch
            {
                failed = true;
                
            }

            Assert.AreEqual(false, failed);
        }
    }
}
