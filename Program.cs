namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {

            Pathfinder fileLogWriter = new Pathfinder(new FileLogWritter());
            Pathfinder consoleLogger = new Pathfinder(new ConsoleLogWritter());
            Pathfinder fridayFileLogWriter = new Pathfinder(new FridayLogWriter(new FileLogWritter()));
            Pathfinder fridayConsoleLogger = new Pathfinder(new FridayLogWriter(new ConsoleLogWritter()));

            List<ILogger> loggers = new List<ILogger> { new ConsoleLogWritter(), new FridayLogWriter(new FileLogWritter()) };

            Pathfinder consolAndFridayFileLogWriter = new Pathfinder(new SeveralLogWriters(loggers));

            fileLogWriter.Log("File message");
            consoleLogger.Log("Console message");
            fridayFileLogWriter.Log("Friday file message");
            fridayConsoleLogger.Log("Friday console message");
            consolAndFridayFileLogWriter.Log("Daily message");
        }
    }
}