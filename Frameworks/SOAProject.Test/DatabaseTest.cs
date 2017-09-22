using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOA_Project.Data;

namespace SOAProject.Test
{
    [TestClass]
    public class DatabaseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
         NorthwindEntities northwindEntities = new NorthwindEntities();

            northwindEntities.categories;

            foreach (category cat in northwindEntities.categories)
            {
                System.Diagnostics.Debug.WriteLine(String.Format("Category: CategoryID {0}", cat.CategoryID));
            }
        }
    }
}
