namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            Pathfinder fileLogWriter = new Pathfinder(new FileLogWritter("File message"));
            Pathfinder consoleLogger = new Pathfinder(new ConsoleLogWritter("Console message"));
            Pathfinder fridayFileLogWriter = new Pathfinder(new FridayLogWriter(new FileLogWritter("Friday file message")));
            Pathfinder fridayConsoleLogger = new Pathfinder(new FridayLogWriter(new ConsoleLogWritter("Friday console message")));
            Pathfinder consolAndFridayFileLogWriter = new Pathfinder(new ConsolLogAndFridayFileLogWriter("Message"));

            fileLogWriter.Log();
            consoleLogger.Log();
            fridayFileLogWriter.Log();
            fridayConsoleLogger.Log();
            consolAndFridayFileLogWriter.Log();
        }
    }
}