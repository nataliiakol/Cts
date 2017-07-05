using System;
using System.Collections;
using System.Collections.Generic;
using CTS.BusinessLayer.Tasks;

namespace CTS.BusinessLayer.Users
{

    public class Developer : DevelopmentTeamUser, IComparable {

        public List<Task> tasksToDo;
        public Developer() {
            tasksToDo = new List<Task>();
        }

        public int CompareTo(object obj) {
            if (obj == null) return 1;
            Developer otherDeveloper = obj as Developer;
            if (otherDeveloper != null) {
                int developersComparison = this.vSeniorityLevel.CompareTo(otherDeveloper.vSeniorityLevel);
                if (developersComparison != 0) {
                    return developersComparison;
                }
                else {
                    return this.Salary.CompareTo(otherDeveloper.Salary);
                }
            }
            else
                throw new ArgumentException("Object is not a Tester");
        }

        public void EstimateTask()
        {
            throw new System.NotImplementedException();
        }

        public void DoWork(DisplayMessage del) {
            {
                System.Threading.Tasks.Task Task = new System.Threading.Tasks.Task(() => {
                    System.Threading.Thread.Sleep(1000);
                    del("Developer at work!");
                });
                Task.Start();
                Task.Wait();
            }
        }
    }
}
