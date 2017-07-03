using System;

namespace CTS.BusinessLayer.Users {

    public delegate string DisplayMessage(string message);
    public abstract class SystemUser {
        public string UserId { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public SeniorityLevel vSeniorityLevel { get; set; }


        public enum SeniorityLevel {
            junior,
            middle,
            senior
        }

        protected SystemUser(string UserId, string Name) {
            this.Name = Name;
            this.UserId = UserId;
        }

        protected SystemUser() { }

        public void ReceiveSalary() {           
            Console.WriteLine("I received salary today!"+Salary);
        }
    }
}