namespace Logging
{
    internal class ConsoleLogWritter : ILogger
    {
        public void WriteError(string message)
        {
            Console.WriteLine(message);
        }
    }
}