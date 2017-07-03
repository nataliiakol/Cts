using CTS.BusinessLayer;
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
            tester.Salary = 2000;
            company.OnSalaryGiven += dev.ReceiveSalary;
            company.OnSalaryGiven += tester.ReceiveSalary;
            company.GiveSalary();
        }
    }
}