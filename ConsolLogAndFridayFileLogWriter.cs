namespace Logging
{
    internal class ConsolLogAndFridayFileLogWriter : ILogger
    {
        private string _message;

        public ConsolLogAndFridayFileLogWriter(string message)
        {
            _message = message;
        }

        public void WriteError()
        {
            Console.WriteLine(_message);

            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                File.WriteAllText("log.txt", _message);
            }
        }
    }
}