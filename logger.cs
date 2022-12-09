using System;

    public interface ILog { void Log(string message); }
    public class logger : ILog 
    {
         public void Log(string message)
        {
            Console.WriteLine(message);
        }

    }
