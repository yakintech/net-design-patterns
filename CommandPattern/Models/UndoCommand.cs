using System;
namespace CommandPattern.Models
{
    public class UndoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Undo command worked.");
        }
    }
}

