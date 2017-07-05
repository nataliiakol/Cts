using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTS.BusinessLayer;
using CTS.BusinessLayer.Users;
using CTS.Reports;

namespace CTS.ApplicationLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Application.FillData();
            Application.CompanyGiveSalary();
            Application.CompanyGiveTasks();
            Reports.Reports.GenerateDevelopersReportByLevel(CompanyStorage.Developers);
            Reports.Reports.GenerateReportSortedTestersBySalary(CompanyStorage.Testers);
            Reports.Reports.GenerateReportFindUsersByName(CompanyStorage.Developers, CompanyStorage.Testers);
            Reports.Reports.GenerateReportSortedDevelopersByTasksAmount(CompanyStorage.Developers);
        }
    }
}
