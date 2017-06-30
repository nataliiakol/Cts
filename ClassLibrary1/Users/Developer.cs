using System;
using System.Collections;

namespace ClassLibrary1.Users
{
    public class Developer : SystemUser, IComparable
    {
        public void DoTask() {
            
        }

        public void EstimateTask() {
            throw new System.NotImplementedException();
        }

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
    }
}
