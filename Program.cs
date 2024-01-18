//Joshua Thatcher
//Dice Rolling Simulation

using System;

class DiceSimulator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");

        // Get user input for the number of dice rolls
        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        // Create an instance of the dice roll class
        DiceRoller roller = new DiceRoller();

        // Get the simulation results and pass in the number of rolls 
        int[] results = roller.SimulateRolls(numberOfRolls);

        // Print out the results
        PrintHistogram(results, numberOfRolls);

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }

    static void PrintHistogram(int[] results, int totalRolls)
    {
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {totalRolls}.\n");

        for (int i = 2; i <= 12; i++)
        {
            int percentage = results[i] * 100 / totalRolls;
            string asterisks = new string('*', percentage);
            Console.WriteLine($"{i}: {asterisks}");
        }
    }
}

//dice roller function that simulates the dice being thrown
class DiceRoller
 
{
    private Random random;

    public DiceRoller()
    {
        random = new Random();
    }

    public int[] SimulateRolls(int numberOfRolls)
    {
        int[] results = new int[13]; 
    //create a for loop to iterate through the dice rolls

        for (int i = 0; i < numberOfRolls; i++)
        {
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int sum = dice1 + dice2;
            results[sum]++;
        }

        return results;
    }
}
