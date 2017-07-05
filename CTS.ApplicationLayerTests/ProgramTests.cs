using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTS.ApplicationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.ApplicationLayer.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            ApplicationLayer.Application.FillData();
            ApplicationLayer.Application.CompanyGiveSalary();
        }
    }
}