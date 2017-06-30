using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Users.Tests
{
    [TestClass()]
    public class TesterTests
    {
        [TestMethod()]
        public void CompareToFirstisJuniorTest() {
            int expectedResult = -1;
            Tester tester1 = new Tester();
            Tester tester2 = new Tester();
            tester1.vSeniorityLevel = SystemUser.SeniorityLevel.junior;
            tester2.vSeniorityLevel = SystemUser.SeniorityLevel.middle;
            int actualResult = tester1.CompareTo(tester2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void CompareToEvenTestersTest()
        {
            int expectedResult = 0;
            Tester tester1 = new Tester();
            Tester tester2 = new Tester();
            tester1.vSeniorityLevel = SystemUser.SeniorityLevel.senior;
            tester2.vSeniorityLevel = SystemUser.SeniorityLevel.senior;
            int actualResult = tester1.CompareTo(tester2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            string expectedResult = "Tester\r\nName: NIK\r\nUser ID: 0192394";
            var tester = new Tester();
            tester.Name = "NIK";
            tester.UserId = "0192394";
            string actualResult = tester.ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}