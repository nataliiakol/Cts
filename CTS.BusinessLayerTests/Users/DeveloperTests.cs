using System.Security.Cryptography.X509Certificates;
using ClassLibrary1.Users;
using CTS.BusinessLayer.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CTS.BusinessLayerTests.Users
{
    [TestClass()]
    public class DeveloperTests
    {
        [TestMethod()]
        public void DoWorkTest()
        {
            DisplayMessage messageDelegate = new DisplayMessage(Developer.DoTask);
            Developer.DoWork(messageDelegate);
        }

        [TestMethod()]
        public void DoTaskTest()
        {
            string expectedResult = "Hello, I develop!";
            DisplayMessage messageDelegate = new DisplayMessage(Developer.DoTask);
            string actualResult=messageDelegate("Hello, I develop!");
            Assert.AreEqual(expectedResult, actualResult);
        }

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