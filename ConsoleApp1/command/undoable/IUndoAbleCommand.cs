namespace ConsoleApp1.command.undoable;

public interface IUndoAbleCommand : ICommand
{
    void UnExecute();
}