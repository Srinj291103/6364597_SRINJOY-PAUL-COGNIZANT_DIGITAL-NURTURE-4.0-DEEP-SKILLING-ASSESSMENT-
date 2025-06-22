using System;

namespace DesignPatternsPrinciples
{
    public class AppLogger
    {
        private static readonly AppLogger instance = new AppLogger();

        private AppLogger()
        {
            Console.WriteLine("Logger has been initialized.");
        }

        public static AppLogger Instance => instance;

        public void LogMessage(string message)
        {
            Console.WriteLine($"[Log] {message}");
        }
    }


    class LoggerMain
    {
        static void Main(string[] args) // ✅ Required entry point
        {
            AppLogger logger1 = AppLogger.Instance;
            AppLogger logger2 = AppLogger.Instance;

            logger1.LogMessage("System is starting.");
            logger2.LogMessage("Executing main workflow...");

            if (ReferenceEquals(logger1, logger2))
            {
                Console.WriteLine("Confirmed: logger1 and logger2 refer to the same instance. So SINGLETON is WORKING");
            }
            else
            {
                Console.WriteLine("Singleton failed: Different logger instances created.");
            }
        }
    }
}
