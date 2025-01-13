namespace Logging
{
    internal class FileLogWritter : ILogger
    {
        private string _message;

        public FileLogWritter(string message)
        {
            _message = message;
        }

        public virtual void WriteError()
        {
            File.WriteAllText("log.txt", _message);
        }
    }
}