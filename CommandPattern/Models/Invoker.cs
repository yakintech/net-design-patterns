using System;
namespace CommandPattern.Models
{
    public class Invoker
    {
        private Stack<ICommand> commandList = new Stack<ICommand>();

        public void ExecuteAll()
        {
            while (commandList.Count > 0)
                commandList.Pop().Execute();
        }

        public void AddCommand(ICommand c)
        {
            commandList.Push(c);
        }
    }
}

