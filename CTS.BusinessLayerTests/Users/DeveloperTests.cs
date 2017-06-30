using ClassLibrary1.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CTS.BusinessLayerTests.Users
{
    [TestClass()]
    public class DeveloperTests
    {
        [TestMethod()]
        public void CompareToWithoutSalaryTest()
        {
            int expectedResult = -1;
            Developer developer1 = new Developer();
            Developer developer2 = new Developer();
            developer1.vSeniorityLevel = SystemUser.SeniorityLevel.junior;
            developer2.vSeniorityLevel = SystemUser.SeniorityLevel.middle;
            int actualResult = developer1.CompareTo(developer2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void CompareToWithSalaryTest()
        {
            int expectedResult = 1;
            Developer developer1 = new Developer();
            Developer developer2 = new Developer();
            developer1.vSeniorityLevel = SystemUser.SeniorityLevel.junior;
            developer2.vSeniorityLevel = SystemUser.SeniorityLevel.junior;
            developer1.Salary = 5000;
            developer2.Salary = 4500;
            int actualResult = developer1.CompareTo(developer2);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}