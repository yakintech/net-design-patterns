using System;
namespace StrategyPattern.Models
{
    public class WalkStrategy : Strategy
    {
        public void doAlgorithm()
        {
            Console.Write("Walking...");
        }
    }
}

