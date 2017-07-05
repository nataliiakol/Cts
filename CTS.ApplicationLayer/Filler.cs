using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTS.BusinessLayer;
using CTS.BusinessLayer.Users;
using Task = CTS.BusinessLayer.Tasks.Task;

namespace CTS.ApplicationLayer
{
    public static class Filler {
        public static CompanyStorage Company;

        public static void FillCompany() {
            Company = new CompanyStorage();
        }

        public static void FillTesters() {
            CompanyStorage.Testers = new List<Tester>();
            CompanyStorage.Testers.Add(new Tester() {Name = "Nik", vSeniorityLevel =DevelopmentTeamUser.SeniorityLevel.junior ,Salary = 1000});
            CompanyStorage.Testers.Add(new Tester() {Name = "Lev", vSeniorityLevel =DevelopmentTeamUser.SeniorityLevel.senior ,Salary = 2000});
            CompanyStorage.Testers.Add(new Tester() {Name = "Kolia", vSeniorityLevel =DevelopmentTeamUser.SeniorityLevel.middle ,Salary = 1500});
            CompanyStorage.Testers.Add(new Tester() {Name = "Sasha", vSeniorityLevel =DevelopmentTeamUser.SeniorityLevel.junior ,Salary = 800});
            CompanyStorage.Testers.Add(new Tester() {Name = "Maks", vSeniorityLevel =DevelopmentTeamUser.SeniorityLevel.senior ,Salary = 3000});
            CompanyStorage.Testers.Add(new Tester() {Name = "Emma", vSeniorityLevel =DevelopmentTeamUser.SeniorityLevel.junior ,Salary = 500});
        }

        public static void FillDevelopers() {
            CompanyStorage.Developers = new List<Developer>();
            CompanyStorage.Developers.Add(new Developer() { Name = "Ksena", vSeniorityLevel = DevelopmentTeamUser.SeniorityLevel.senior, Salary = 5000 });
            CompanyStorage.Developers.Add(new Developer() { Name = "Leya", vSeniorityLevel = DevelopmentTeamUser.SeniorityLevel.junior, Salary = 1500 });
            CompanyStorage.Developers.Add(new Developer() { Name = "Luk", vSeniorityLevel = DevelopmentTeamUser.SeniorityLevel.senior, Salary = 4000 });
            CompanyStorage.Developers.Add(new Developer() { Name = "Phoebe", vSeniorityLevel = DevelopmentTeamUser.SeniorityLevel.middle, Salary = 3000 });
            CompanyStorage.Developers.Add(new Developer() { Name = "Buffy", vSeniorityLevel = DevelopmentTeamUser.SeniorityLevel.middle, Salary = 3000 });
            CompanyStorage.Developers.Add(new Developer() { Name = "Willow", vSeniorityLevel = DevelopmentTeamUser.SeniorityLevel.middle, Salary = 2500 });
            CompanyStorage.Developers.Add(new Developer() { Name = "Penny", vSeniorityLevel = DevelopmentTeamUser.SeniorityLevel.junior, Salary = 1200 });
        }

        public static void FillTasks() {
            CompanyStorage.Tasks = new List<BusinessLayer.Tasks.Task>();
            CompanyStorage.Tasks.Add(new BusinessLayer.Tasks.Task() { vPriority = BusinessLayer.Tasks.Task.Priority.low });
            CompanyStorage.Tasks.Add(new BusinessLayer.Tasks.Task() { vPriority = BusinessLayer.Tasks.Task.Priority.high });
            CompanyStorage.Tasks.Add(new BusinessLayer.Tasks.Task() { vPriority = BusinessLayer.Tasks.Task.Priority.low });
            CompanyStorage.Tasks.Add(new BusinessLayer.Tasks.Task() { vPriority = BusinessLayer.Tasks.Task.Priority.medium });
            CompanyStorage.Tasks.Add(new BusinessLayer.Tasks.Task() { vPriority = BusinessLayer.Tasks.Task.Priority.medium });
            CompanyStorage.Tasks.Add(new BusinessLayer.Tasks.Task() { vPriority = Task.Priority.low });
        }

        public static void FillManager() {
            Manager.Instance(Company);
        }

    }
}
