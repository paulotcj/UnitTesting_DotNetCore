using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;

namespace MyClassesTest
{
    [TestClass]
    public class PersonTest : TestBase
    {
        [TestMethod]
        public void IsNullTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;

            //isSupervisor is set and a supervisor needs to have a first name
            // therefore the result should be null
            per = mgr.CreatePerson("", "Sheriff", true);

            Assert.IsNull(per);
        }

        [TestMethod]
        public void IsInstanceOfTypeTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;

            per = mgr.CreatePerson("Paul", "Sheriff",
                                  true);

            Assert.IsInstanceOfType(per, 
                        typeof(Supervisor));
        }

    }
}
