using System;

class Logger
{

 private static readonly Logger instance = new Logger();
 private Logger()
 {
 Console.WriteLine("Logger initialized");
 }

 
 public static Logger GetInstance()
 {
 return instance;
} 
 public void Log(string message)
 {
 Console.WriteLine($"LOG: {message}");
}
}

class Program
{
 static void Main()
 {
 
 Logger logger1 = Logger.GetInstance();
Logger logger2 = Logger.GetInstance();
 logger1.Log("Application started");
 logger2.Log("Performing some operations"); 
 if (ReferenceEquals(logger1, logger2))
 {
 Console.WriteLine("logger1 and logger2 are the same instance (Singleton works)");
 }
 else
 {
 Console.WriteLine("Different instances detected (Singleton failed)");
 }
}
}