// See https://aka.ms/new-console-template for more information


using ConsoleApp1.command;
using ConsoleApp1.command.undoable;

var history = new History();
var document = new HtmlDocument
{
    Content = "Hello World"
};
var boldCommand = new BoldCommand(history, document);
boldCommand.Execute(); //bold 

var italicCommand = new ItalicCommand(history, document);
italicCommand.Execute(); //italic

var undoCommand = new UndoCommand(history);
undoCommand.Execute(); //bold
undoCommand.Execute(); //default

Console.WriteLine(document.Content); //default