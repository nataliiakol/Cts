using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using CTS.BusinessLayer.Users;

namespace CTS.Reports {
    public static class Reports {

        public static void GenerateDevelopersReportByLevel(List<Developer> developers) {
            var developersSortedByLevel = from developer in developers
                where developer.vSeniorityLevel == DevelopmentTeamUser.SeniorityLevel.middle
                select developer;
            Console.WriteLine("This are middle developers:");
            foreach (var developer in developersSortedByLevel) {
                Console.WriteLine(developer.ToString());
            }
        }

        public static void GenerateReportSortedTestersBySalary(List<Tester> testers) {
            var testersSortedBySalary = from tester in testers
                orderby tester.Salary
                select tester;
            Console.WriteLine("This are testers sorted by salary:");
            foreach (var tester in testersSortedBySalary) {
                Console.WriteLine(tester.ToString());
            }
        }

        public static void GenerateReportSortedDevelopersByTasksAmount(List<Developer> developers) {
            var developersSortedByTasks = from developer in developers
                orderby developer.tasksToDo.Count
                select developer;
            Console.WriteLine("This are developers sorted by amount of tasks:");
            foreach (var developer in developersSortedByTasks) {
                Console.WriteLine(developer.ToString());
            }
        }

        public static void GenerateReportFindUsersByName(List<Developer> developers, List<Tester> testers)
        {
            List<DevelopmentTeamUser> systemUsers = new List<DevelopmentTeamUser>();
            systemUsers.AddRange(developers);
            systemUsers.AddRange(testers);
            var systemUsersFoundByName = from user in systemUsers
                where user.Name == "Nik"
                select user;
            Console.WriteLine("This are developers sorted by amount of tasks:");
            foreach (var user in systemUsersFoundByName)
            {
                Console.WriteLine(user.ToString());
            }
        }

    }
}