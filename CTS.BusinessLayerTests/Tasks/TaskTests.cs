using ClassLibrary1.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CTS.BusinessLayerTests.Tasks
{
    [TestClass()]
    public class TaskTests
    {
        [TestMethod()]
        public void CompareToWithoutEstimationTest()
        {
            int expectedResult = -1;
            Task task1 = new Task();
            Task task2 = new Task();
            task1.vDifficulty = Task.Difficulty.medium;
            task2.vDifficulty = Task.Difficulty.difficult;
            int actualResult = task1.CompareTo(task2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void CompareToWithEstimationTest()
        {
            int expectedResult = -1;
            Task task1 = new Task();
            Task task2 = new Task();
            task1.vDifficulty = Task.Difficulty.medium;
            task2.vDifficulty = Task.Difficulty.medium;
            task1.Estimation = 10;
            task2.Estimation = 20;
            int actualResult = task1.CompareTo(task2);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}