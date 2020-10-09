using System;
using System.Collections.Generic;

namespace MonthyHall
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfAttempts = 1000000; //accept simulation from user
            int NumberOfWins = 0;
            Random rnd = new Random();
            for (int i = 1; i < NumberOfAttempts; i++)
            {
                //prize randomly placed behind one of the 3 doors
                var PrizeDoor = rnd.Next(1, 4);
                //Contestant randomly pics a door
                var FirstGuessDoor = rnd.Next(1, 4);

                //random door host would open to reveal no prize
                List<int> HostOpenableDoor = new List<int>() { 1, 2, 3 };
                //host wont open the prize door 
                HostOpenableDoor.Remove(PrizeDoor);
                //host wont open the originaly guessed door 
                HostOpenableDoor.Remove(FirstGuessDoor);

                //which one of the non-prize door the host will open 
                var HostOpenedDoor = HostOpenableDoor[rnd.Next(0, (HostOpenableDoor.Count))];

                //figure out ehich door the contestant is switching to 
                List<int> SelectableDoors = new List<int>() { 1, 2, 3 };

                //contestant will not have a option to select the door that is open 
                SelectableDoors.Remove(HostOpenedDoor);
                //contestant dont want to select the first guess
                SelectableDoors.Remove(FirstGuessDoor);

                // the open left is the switched selection
                var SwitchedGuessDoor = SelectableDoors[0];

                //check if they won by swtiching 
                if (PrizeDoor == SwitchedGuessDoor)
                {
                    NumberOfWins++;
                }
            }

            Console.WriteLine("Number if wins after Switching : " + NumberOfWins.ToString() + " Out of " + NumberOfAttempts.ToString());
            // Console.WriteLine("Which is " + ((Convert.ToDouble(NumberOfWins) / Convert.ToDouble(NumberOfAttempts)) * 100).ToString("0.00") + "%");
            Console.WriteLine("Press Enter to countinue");
            Console.ReadLine();
            
        }
    }
}
