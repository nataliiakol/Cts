using System;

namespace ClassLibrary1.Users {
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
    }
}