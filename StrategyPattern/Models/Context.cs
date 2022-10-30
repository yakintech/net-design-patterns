using System;
namespace StrategyPattern.Models
{
    public class Context
    {
        Strategy strategy;
        // Constructor
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public void ContextInterface()
        {
            strategy.doAlgorithm();
        }
    }
}

