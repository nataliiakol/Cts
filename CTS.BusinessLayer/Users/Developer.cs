using System;
using System.Collections;
using ClassLibrary1.Users;

namespace CTS.BusinessLayer.Users
{
    public delegate void DisplayMessage(string message);
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

        public static void DoTask(DisplayMessage message)
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(message);
        }

        public void EstimateTask()
        {
            throw new System.NotImplementedException();
        }

    }
}
