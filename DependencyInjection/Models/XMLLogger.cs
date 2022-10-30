using System;
namespace DependencyInjection.Models
{
    public class XMLLogger : ILogger
    {
        public void PrintLog()
        {
            Console.WriteLine("XML Log..");
        }
    }
}

