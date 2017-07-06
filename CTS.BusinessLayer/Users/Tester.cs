using System;
using System.Collections.Generic;
using System.Text;
using CTS.BusinessLayer.Tasks;

namespace CTS.BusinessLayer.Users
{
    public class Tester : DevelopmentTeamUser, IComparable {

        public List<Task> tasksToDo;

        public Tester() {
                
        }
        public void EstimateTask() {
            throw new System.NotImplementedException();
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tester");
            sb.AppendLine("Name: " + Name);
            sb.AppendLine("Salary: " + Salary);
            return sb.ToString();
        }

        public int CompareTo(object obj) {
            if (obj == null) return 1;
            Tester otherTester = obj as Tester;
            if (otherTester != null) 
                return this.vSeniorityLevel.CompareTo(otherTester.vSeniorityLevel);
            else      
                 throw new ArgumentException("Object is not a Tester");
                
        }     

        public void DoWork(DisplayMessage del)
        {
            System.Threading.Tasks.Task Task = new System.Threading.Tasks.Task(() => {
                System.Threading.Thread.Sleep(1000);
                del("Tester at work!");
            });
            Task.Start();
            Console.Read();
        }
    }

    }

