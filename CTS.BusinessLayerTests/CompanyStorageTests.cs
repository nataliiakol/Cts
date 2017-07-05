using System.Collections.Generic;
using CTS.BusinessLayer;
using CTS.BusinessLayer.Tasks;
using CTS.BusinessLayer.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CTS.BusinessLayerTests
{
    [TestClass()]
    public class CompanyStorageTests
    {
        [TestMethod()]
        public void GiveSalaryTest()
        {
            CompanyStorage company = new CompanyStorage();
            Developer dev = new Developer();
            Tester tester = new Tester();
            dev.Salary = 1000;
            dev.Name = "Nik";
            tester.Salary = 2000;
            tester.Name = "Leo";
            company.GiveSalary();
        }
    }
}