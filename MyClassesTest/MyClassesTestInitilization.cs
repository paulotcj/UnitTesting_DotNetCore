using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassesTest
{
    [TestClass]
    public class MyClassesTestInitilization
    {
        [AssemblyInitialize()]
        public static void AssemblyInitialize(TestContext tc)
        {
            // todo - initialize for all tests withing an assembly
            tc.WriteLine("In AssemblyInitialize() method");
        }


        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            // todo - clean up
            
        }
    }
}
