using System;
using System.Collections;

namespace CTS.BusinessLayer.Users
{

    public class Developer : SystemUser, IComparable
    {
        public Developer() {
            
        }

        public int CompareTo(object obj) {
            int developersComparison=1;
            Developer otherDeveloper = obj as Developer;
            if (otherDeveloper != null) {
                developersComparison = this.vSeniorityLevel.CompareTo(otherDeveloper.vSeniorityLevel);
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

        public static string DoTask(string message)
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(message);
            return message;
        }

        public static void DoWork(DisplayMessage del) {
            del("Developer at work!");
        }
    }
}
