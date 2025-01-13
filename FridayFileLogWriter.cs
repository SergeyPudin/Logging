namespace Logging
{
    internal class FridayFileLogWriter : ILogger
    {
        private ILogger _logger;

        public FridayFileLogWriter(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteError()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                _logger.WriteError();
            }
        }
    }
}