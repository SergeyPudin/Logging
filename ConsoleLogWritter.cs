namespace Logging
{
    internal class ConsoleLogWritter : ILogger
    {
        private string _message;

        public ConsoleLogWritter(string message)
        {
            _message = message;
        }

        public void WriteError()
        {
            Console.WriteLine(_message);
        }
    }
}