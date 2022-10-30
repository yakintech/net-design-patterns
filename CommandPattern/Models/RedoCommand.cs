using System;
namespace CommandPattern.Models
{
    public class RedoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Redo command worked.");
        }
    }
}

