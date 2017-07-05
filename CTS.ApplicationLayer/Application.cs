using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTS.BusinessLayer;

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
            Filler.Company.GiveSalary();
        }

        public static void CompanyGiveTasks() {
            Filler.Company.GiveTasks();
        }
    }
}
