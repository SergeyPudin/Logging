namespace Logging
{
    internal class Pathfinder
    {
        private ILogger _logger;

        public Pathfinder(ILogger logger)
        {
            _logger = logger;
        }

        public void Log()
        {
            _logger.WriteError();
        }
    }
}