using System;

namespace CTS.BusinessLayer.Users
{
    public class Tester : SystemUser, IComparable {

        public void EstimateTask() {
            throw new System.NotImplementedException();
        }

        public override string ToString() {
            return "Tester\r\n" + "Name: " + Name + "\r\n" + "User ID: " + UserId;
        }

        public int CompareTo(object obj) {
            if (obj == null) return 1;


            Tester otherTeser = obj as Tester;
            if (otherTeser != null) 
                return this.vSeniorityLevel.CompareTo(otherTeser.vSeniorityLevel);
            else
                
                 throw new ArgumentException("Object is not a Tester");
                
        }
        public static string DoTask(string message)
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(message);
            return message;
        }
    }

    }

