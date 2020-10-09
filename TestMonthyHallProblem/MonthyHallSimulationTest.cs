using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonthyHallProblem;

namespace TestMonthyHallProblem
{
    [TestClass]
    public class MonthyHallSimulationTest
    {
        [TestMethod]
        public void TestMonthyHallSimulation_VaidNoOfAttempts()
        {
            int NoofAttempts = 1000;
            bool ischoice = false; 
            //int expectedresult_1 = 0;
            MonthyHallProblem.BusinessClass.SimulationResult result;
            MonthyHallProblem.BusinessClass.SimulationResult expectedresult = new MonthyHallProblem.BusinessClass.SimulationResult();
            expectedresult.NoOfSimulation = 1000;
            expectedresult.NoOfSwitchWin = 332;
            result = MonthyHallProblem.BusinessClass.SimulationCalculation.SimulationResult(NoofAttempts, ischoice);

            Assert.Equals(expectedresult.NoOfSwitchWin, result.NoOfSwitchWin);
        }

        //Test eg:

        //        {
        //  "noOfSimulation": 100000,
        //  "switch": true,
        //  "noOfSwitchWin": 66680,
        //  "noOfStayWin": 33320
        //}

        //{
        //  "noOfSimulation": 100000,
        //  "switch": false,
        //  "noOfSwitchWin": 66766,
        //  "noOfStayWin": 33234
        //}

        //{
        //  "noOfSimulation": 80000,
        //  "switch": false,
        //  "noOfSwitchWin": 52980,
        //  "noOfStayWin": 27020
        //}

        //{
        //  "noOfSimulation": 80000,
        //  "switch": true,
        //  "noOfSwitchWin": 53190,
        //  "noOfStayWin": 26810
        //}
        //
    }
}
