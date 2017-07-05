using System.Security.Cryptography.X509Certificates;
using CTS.BusinessLayer;
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
            Developer developer1 = new Developer();
            Developer developer2 = new Developer();
            Developer developer3 = new Developer();
            DisplayMessage messageDelegate = new DisplayMessage(CompanyStorage.LogTask);
            messageDelegate += CompanyStorage.LogTask;
            developer1.DoWork(messageDelegate);
            developer2.DoWork(messageDelegate);
            developer3.DoWork(messageDelegate);
        }
        [TestMethod()]
        public void CompareToWithoutSalaryTest()
        {
            int expectedResult = -1;
            Developer developer1 = new Developer();
            Developer developer2 = new Developer();
            developer1.vSeniorityLevel = DevelopmentTeamUser.SeniorityLevel.junior;
            developer2.vSeniorityLevel = DevelopmentTeamUser.SeniorityLevel.middle;
            int actualResult = developer1.CompareTo(developer2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void CompareToWithSalaryTest()
        {
            int expectedResult = 1;
            Developer developer1 = new Developer();
            Developer developer2 = new Developer();
            developer1.vSeniorityLevel = DevelopmentTeamUser.SeniorityLevel.junior;
            developer2.vSeniorityLevel = DevelopmentTeamUser.SeniorityLevel.junior;
            developer1.Salary = 5000;
            developer2.Salary = 4500;
            int actualResult = developer1.CompareTo(developer2);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}