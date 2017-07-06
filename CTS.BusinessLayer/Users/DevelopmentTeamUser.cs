using System;
using System.Collections.Generic;
using System.IO;

namespace CTS.BusinessLayer.Users {

    public delegate string DisplayMessage(string message);

    public abstract class DevelopmentTeamUser : ISystemUser {
        public string UserId { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public static List<string> salaryLog { get; set; }
        public SeniorityLevel vSeniorityLevel { get; set; }

        public enum SeniorityLevel {
            junior,
            middle,
            senior
        }

        protected DevelopmentTeamUser(string UserId, string Name) {
            this.Name = Name;
            this.UserId = UserId;
        }

        protected DevelopmentTeamUser() {
            CompanyStorage.OnSalaryGiven += new SalaryTime(ReceiveSalary);
        }

        public void ReceiveSalary() {        
            salaryLog.Add("My name is " + Name + ", I received "+Salary);
        }

        public override string ToString() {
            return Name + " " + vSeniorityLevel;
        }
    }
}