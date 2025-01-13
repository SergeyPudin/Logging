namespace Logging
{
    internal class SeveralLogWriters : ILogger
    {
        private IEnumerable<ILogger> _loggers;

        public SeveralLogWriters(IEnumerable<ILogger> loggers)
        {
            _loggers = loggers;
        }

        public void WriteError(string message)
        {
            foreach (var logger in _loggers)
            {
                logger.WriteError(message);
            }
        }
    }
}