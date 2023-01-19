using System;

namespace diceRoller
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate?");

            // Get user input, convert to int
            int numRolls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numRolls}\n");

            // Initialize countArray where totals for each result will be stored/updated
            int[] countArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // Create random instance
            Random rnd = new Random();

            // Iterates through user's inputted number of dice rolls
            for (int i = 0; i < numRolls; i++)
            {
                // Roll 2 6-sided dice using the random instance created before
                int die1 = rnd.Next(1, 7);
                int die2 = rnd.Next(1, 7);

                // index [0] in countArray corresponds with a dice roll of 2, [1] with 3, etc.
                if (die1 + die2 == 2) { countArray[0]++; } // add 1 to current array item's value
                else if (die1 + die2 == 3) { countArray[1]++; }
                else if (die1 + die2 == 4) { countArray[2]++; }
                else if (die1 + die2 == 5) { countArray[3]++; }
                else if (die1 + die2 == 6) { countArray[4]++; }
                else if (die1 + die2 == 7) { countArray[5]++; }
                else if (die1 + die2 == 8) { countArray[6]++; }
                else if (die1 + die2 == 9) { countArray[7]++; }
                else if (die1 + die2 == 10) { countArray[8]++; }
                else if (die1 + die2 == 11) { countArray[9]++; }
                else if (die1 + die2 == 12) { countArray[10]++; }
            }

            // For each result in the array (represents 2-12)
            for (int i = 0; i < countArray.Length; i++)
            {
                // Calculate a rounded percentage of rolls for current result
                int resultPercent = (int)((100f * countArray[i]) / numRolls);

                //Initialize asterix string
                string asterixString = "";

                // For each percent of current result, add an asterix
                for (int j = 0; j < resultPercent; j++)
                {
                    asterixString += "*";
                }

                // Print results (e.g. "5: ***********")
                Console.WriteLine($"\r{i + 2}: {asterixString}");
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}