using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonthyHallProblem.BusinessClass
{
    public class SimulationCalculation
    {

        public static SimulationResult SimulationResult(int NumberOfAttempts, bool doSwitch)
        {
            SimulationResult simulationResult = new SimulationResult();
            int switchWins = 0;
            int stayWins = 0;
            try
            {
                Random rnd = new Random();

                for (int i = 0; i < NumberOfAttempts; i++)
                {
                    int[] doors = { 0, 0, 0 };//0 is a goat, 1 is a car

                    var prizedoor = rnd.Next(3);
                    doors[prizedoor] = 1; //set winner in a random door

                    int choice = rnd.Next(3); //select a randon door
                    int shown; //the shown door
                    do
                    {
                        shown = rnd.Next(3);
                    }
                    while (doors[shown] == 1 || shown == choice); //don't show the PrizeDoor or the choice

                    stayWins += doors[choice]; //if you won by staying, count it

                    //the switched (last remaining) door is (3 - choice - shown), as 0+1+2=3
                    switchWins += doors[3 - choice - shown];
                }

                Console.Out.WriteLine("Staying wins " + stayWins + " times.");
                Console.Out.WriteLine("Switching wins " + switchWins + " times.");

                simulationResult.NoOfSimulation = NumberOfAttempts;
                simulationResult.NoOfStayWin = stayWins;
                simulationResult.NoOfSwitchWin = switchWins;
                simulationResult.Switch = doSwitch;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            return simulationResult;
        }

    }
}
