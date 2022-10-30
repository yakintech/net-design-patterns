using System;
namespace StrategyPattern.Models
{
    public class BusStrategy : Strategy
    {
        public void doAlgorithm()
        {
            Console.WriteLine("Busss");
        }
    }
}

