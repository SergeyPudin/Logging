namespace Logging
{
    internal class FridayLogWriter : ILogger
    {
        private ILogger _logger;

        public FridayLogWriter(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteError()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("FileWrited");
                _logger.WriteError();
            }
        }
    }
}