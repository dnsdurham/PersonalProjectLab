using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = true;

            while (shouldContinue)
            {
                // Prompt the user to indicate which type of stat they wish to calculate
                Console.WriteLine("Enter 1 for batting average and 2 for slugging percentage");
                string stat = Console.ReadLine();
                // If they select batting average
                if (stat == "1")
                {
                    int hits = 0;
                    int walks = 0;
                    int atBats = 0;
                    string input = "";
                    // Prompt them to enter the number of hits, walks, total at bats
                    Console.WriteLine("Enter the number of hits");
                    input = Console.ReadLine();
                    hits = int.Parse(input);
                    Console.WriteLine("Enter the number of walks");
                    input = Console.ReadLine();
                    walks = int.Parse(input);
                    Console.WriteLine("Enter the number of at bats");
                    input = Console.ReadLine();
                    atBats = int.Parse(input);

                    // Calculate the batting average
                    BaseballStats stats = new BaseballStats();
                    decimal avg = stats.CalculateBattingAverage(hits, walks, atBats);
                    
                    // Write the batting average to the console
                    Console.WriteLine("Batting average: " + avg);
                }
                // Else if they select slugging percentage
                else if (stat == "2")
                {
                        int singles = 0;
                        int doubles = 0;
                        int triples = 0;
                        int homeRuns = 0;
                        int walks = 0;
                        int atBats = 0;
                        string input = "";
                        // Prompt them to enter the number of singles, double, triples, home runs, and at bats
                        Console.WriteLine("Enter the number of singles");
                        input = Console.ReadLine();
                        singles = int.Parse(input);
                        Console.WriteLine("Enter the number of doubles");
                        input = Console.ReadLine();
                        doubles = int.Parse(input);
                        Console.WriteLine("Enter the number of triples");
                        input = Console.ReadLine();
                        triples = int.Parse(input);
                        Console.WriteLine("Enter the number of home runs");
                        input = Console.ReadLine();
                        homeRuns = int.Parse(input);
                        Console.WriteLine("Enter the number of walks");
                        input = Console.ReadLine();
                        walks = int.Parse(input);
                        Console.WriteLine("Enter the number of at bats");
                        input = Console.ReadLine();
                        atBats = int.Parse(input);

                        // Calculate the slugging percentage
                        BaseballStats stats = new BaseballStats();
                        decimal sluggingPct = stats.CalculateSluggingPercentage(singles, doubles, triples, homeRuns, walks, atBats);
                    
                        // Write the slugging percentage to the console
                        Console.WriteLine("Slugging percentage: " + sluggingPct);                
                }
                
                // Prompt the user to see if they wish to calculate another stat
                Console.WriteLine("Enter 1 for new stat or 2 to quit");
                string anotherStat = Console.ReadLine();
                
                // If they select yes, return to the top of the program
                if (anotherStat == "2")
                {
                    // end the program
                    shouldContinue = false;
                }
            }
            Console.WriteLine("Thanks you for using this program");
        }
    }
}
