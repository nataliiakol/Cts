using System.Collections.Generic;
using CTS.BusinessLayer;
using CTS.BusinessLayer.Tasks;
using CTS.BusinessLayer.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CTS.BusinessLayerTests.Users
{
    [TestClass()]
    public class ManagerTests
    {
        [TestMethod()]
        public void DistributeTasksTest()
        {
            CompanyStorage company = new CompanyStorage();
            Manager manager = Manager.Instance(company);
            CompanyStorage.Developers = new List<Developer>();
            CompanyStorage.Developers.Add(new Developer() {Name = "Kleo"});
            CompanyStorage.Developers.Add(new Developer() {Name = "Fin"});
            CompanyStorage.Developers.Add(new Developer() {Name = "Sara"});
            CompanyStorage.Developers.Add(new Developer() {Name = "Mike"});

            CompanyStorage.Tasks = new List<Task>();
            CompanyStorage.Tasks.Add(new Task() {vPriority = Task.Priority.low});
            CompanyStorage.Tasks.Add(new Task() {vPriority = Task.Priority.high});
            CompanyStorage.Tasks.Add(new Task() {vPriority = Task.Priority.low});
            CompanyStorage.Tasks.Add(new Task() {vPriority = Task.Priority.medium});
            CompanyStorage.Tasks.Add(new Task() {vPriority = Task.Priority.medium});
            CompanyStorage.Tasks.Add(new Task() {vPriority = Task.Priority.low});

            company.GiveTasks();
        }
    }
}