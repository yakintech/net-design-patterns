using CommandPattern.Models;

Invoker invoker = new Invoker();
invoker.AddCommand(new UndoCommand());
invoker.AddCommand(new UndoCommand());
invoker.AddCommand(new RedoCommand());

invoker.ExecuteAll();

Console.ReadLine();