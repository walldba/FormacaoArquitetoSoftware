using System;

namespace DesignPatterns.Structural.Adapter
{
    // Target Class
    public class Logger : ILogger
    {
        public void Log(string message)
        => Console.WriteLine($"Log Padrão {message}");


        public void LogError(Exception exception)
        => Console.WriteLine($"Log padrão {exception.Message}");
    }
}