using System;
using System.Collections.Generic;
using CTS.BusinessLayer.Tasks;

namespace CTS.BusinessLayer.Users
{
    public class Manager : ISystemUser {
        public string UserId { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public List<Task> newTasks;
        private static Manager vInstance;
        private CompanyStorage company;

        protected Manager(CompanyStorage company) {
            this.company = company;
            company.OnTasksGive += DistributeTasks;
        }

        public void DistributeTasks(List<Task> tasksToDistribute) {
            CompanyStorage.SortDevelopersTesters();
            tasksToDistribute.Sort();
            int i = 0;
            int j = 0;
            while (tasksToDistribute[i]!=tasksToDistribute[tasksToDistribute.Count-1]) {
                CompanyStorage.Developers[j].tasksToDo.Add(tasksToDistribute[i]);
                i++;
                j++;
                if (j >= (CompanyStorage.Developers.Count-1)) {
                    j = 0;
                }
            }
        }

        public static Manager Instance(CompanyStorage company) {
            if (vInstance == null) {
                vInstance = new Manager(company);
            }
            return vInstance;
        }

        public void ReceiveSalary() {
            Console.WriteLine("My name is " + Name + ", I received " + Salary);
        }
    }
}
