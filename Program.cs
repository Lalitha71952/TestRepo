using System;

namespace TestRepo
{
    /// &lt;summary&gt;
    /// Main entry point for the TestRepo console application
    /// &lt;/summary&gt;
    class Program
    {
        /// &lt;summary&gt;
        /// Main method - application entry point
        /// &lt;/summary&gt;
        /// &lt;param name="args"&gt;Command line arguments&lt;/param&gt;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome to TestRepo!");
            
            // Example: Display current date and time
            Console.WriteLine($"Current Date and Time: {DateTime.Now}");
            
            // Keep console open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}