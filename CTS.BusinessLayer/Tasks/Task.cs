using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tasks
{
    public class Task : IComparable
    {
        public string TaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Estimation { get; set; }
        public Difficulty vDifficulty;
        public Priority vPriority;

        public enum Difficulty {
            easy, 
            medium,
            difficult
        }

        public enum Priority {
            low,
            medium,
            high
        }

        public int CompareTo(object obj) { 
          int tasksComparison = 1;
          Task otherTask = obj as Task;
          if (otherTask != null) {
              tasksComparison = this.vDifficulty.CompareTo(otherTask.vDifficulty);
            if (tasksComparison != 0) {
              return tasksComparison;
            }
            else {
                return this.Estimation.CompareTo(otherTask.Estimation);
            }
        }
           else
             throw new ArgumentException("Object is not a Tester");
    }
}
}
