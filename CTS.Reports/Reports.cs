using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using CTS.BusinessLayer.Users;
using Task = CTS.BusinessLayer.Tasks.Task;

namespace CTS.Reports {
    public static class Reports {

        public static void WriteReportToFile<T>(string fileName, IEnumerable<T> listOfItems)
        {
            string path = @"C:\GitRepo\" + fileName;
            using (StreamWriter outputFile = new StreamWriter(path))
            {
                foreach (var item in listOfItems)
                    outputFile.WriteLine(item.ToString());
            }
        }

        public static void GenerateDevelopersReportByLevel(List<Developer> developers) {
            var developersSortedByLevel = from developer in developers
                where developer.vSeniorityLevel == DevelopmentTeamUser.SeniorityLevel.middle
                select developer;
             WriteReportToFile<Developer>("DevelopersSortedByLevel.txt", developersSortedByLevel);
        }

        public static void GenerateReportSortedTestersBySalary(List<Tester> testers) {
            var testersSortedBySalary = from tester in testers
                orderby tester.Salary
                select tester;
            WriteReportToFile<Tester>("TestersSortedBySalary.txt", testersSortedBySalary);
        }

        public static void GenerateReportSortedDevelopersByTasksAmount(List<Developer> developers) {
            var developersSortedByTasks = from developer in developers
                orderby developer.tasksToDo.Count
                select developer;
            WriteReportToFile<Developer>("developersSortedByTasks.txt", developersSortedByTasks);
        }

        public static void GenerateReportFindUsersByName(List<Developer> developers, List<Tester> testers, string name) {
            List<DevelopmentTeamUser> systemUsers = new List<DevelopmentTeamUser>();
            systemUsers.AddRange(developers);
            systemUsers.AddRange(testers);
            var systemUsersFoundByName = from user in systemUsers
                where user.Name == name
                select user;
            WriteReportToFile<DevelopmentTeamUser>("UsersWithSpecifiedName.txt", systemUsersFoundByName);
        }

    }
}