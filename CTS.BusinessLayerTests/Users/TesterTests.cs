using System;
using System.Text;
using CTS.BusinessLayer.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CTS.BusinessLayerTests.Users
{
    [TestClass()]
    public class TesterTests
    {
        [TestMethod()]
        public void CompareToFirstisJuniorTest() {
            int expectedResult = -1;
            Tester tester1 = new Tester();
            Tester tester2 = new Tester();
            tester1.vSeniorityLevel = DevelopmentTeamUser.SeniorityLevel.junior;
            tester2.vSeniorityLevel = DevelopmentTeamUser.SeniorityLevel.middle;
            int actualResult = tester1.CompareTo(tester2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void CompareToEvenTestersTest()
        {
            int expectedResult = 0;
            Tester tester1 = new Tester();
            Tester tester2 = new Tester();
            tester1.vSeniorityLevel = DevelopmentTeamUser.SeniorityLevel.senior;
            tester2.vSeniorityLevel = DevelopmentTeamUser.SeniorityLevel.senior;
            int actualResult = tester1.CompareTo(tester2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            var tester = new Tester();
            tester.Name = "NIK";
            tester.Salary = 1000;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tester");
            sb.AppendLine("Name: NIK");
            sb.AppendLine("Salary: 1000");
            string expectedResult = sb.ToString();
            string actualResult = tester.ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}