using System;

namespace ideal
{
    class Program
    {
        // The bias between self-satisfaction and disengagement. Default is 4.
        static int boredomLevel = 2;
        static void Main()
        {
            Console.WriteLine("Set bordedom level of " + boredomLevel + " .");
            Console.WriteLine("Starting the experiment...");
            RunExperiment();
        }
        
        static void RunExperiment()
        {
            // Create an existence with a variable boredom level.
            Existence existence = new Existence(boredomLevel);

            for (int i = 0; i < 20; i++)
            {
                string stepTrace = existence.Step();
                Console.WriteLine(i + ": " + stepTrace);
            }
        }

    }
}
