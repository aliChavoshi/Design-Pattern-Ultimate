// See https://aka.ms/new-console-template for more information


using ConsoleApp1.command;

var compositionCommand = new CompositionCommand();
compositionCommand.Add(new BlackAndWhiteCommand());
compositionCommand.Add(new ResizeCommand());
compositionCommand.Execute();