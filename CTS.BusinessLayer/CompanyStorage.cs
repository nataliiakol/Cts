using System;
using System.Collections.Generic;
using CTS.BusinessLayer.Tasks;
using CTS.BusinessLayer.Users;

namespace CTS.BusinessLayer
{
    public delegate void SalaryTime();
    public delegate void TasksTime(List<Task>tasks);

    public class CompanyStorage {
        private DisplayMessage displayDelegate;
        public static event SalaryTime OnSalaryGiven;
        public event TasksTime OnTasksGive;
        public static List<Tester> Testers;
        public static List<Developer> Developers;
        public static List<Task> Tasks;

        public CompanyStorage()
        {
            displayDelegate = new DisplayMessage(LogTask);
        }

        public void GiveSalary() {
            OnSalaryGiven?.Invoke();
        }

        public void GiveTasks() {
            OnTasksGive?.Invoke(Tasks);
        }

        public static string LogTask(string message)
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(message);
            return message;
        }

        public static void SortDevelopersTesters() {
            //Testers.Sort();
            Developers.Sort();
        }


    }
}
