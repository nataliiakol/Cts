using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTS.BusinessLayer;
using CTS.BusinessLayer.Users;

namespace CTS.ApplicationLayer
{
    public static class Application
    {
        public static void FillData() {
            Filler.FillCompany();
            Filler.FillManager();
            Filler.FillDevelopers();
            Filler.FillTesters();
            Filler.FillTasks();
        }

        public static void CompanyGiveSalary() {
            DevelopmentTeamUser.salaryLog = new List<string>();
            Filler.Company.GiveSalary();
            using (StreamWriter outputFile = new StreamWriter(@"C:\GitRepo\SalaryLog.txt"))
            {
                foreach (string line in DevelopmentTeamUser.salaryLog)
                    outputFile.WriteLine(line);
            }
        }

        public static void CompanyGiveTasks() {
            Filler.Company.GiveTasks();
        }
    }
}
