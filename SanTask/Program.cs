using System;

public class Logger
{
    // Private instance of the Logger
    private static Logger instance;

    // Private constructor to prevent external instantiation
    private Logger() { }

    // Public method to get the singleton instance of Logger
    public static Logger GetInstance()
    {
        if (instance == null)
        {
            instance = new Logger();
        }
        return instance;
    }

    // Public method to log a message
    public void Log(string message)
    {
        // Print the message to the console
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get the singleton instance of Logger
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();


        // Log some messages
        logger1.Log("Message from a logger.");
        logger2.Log("Another message from a logger.");
    }
}
