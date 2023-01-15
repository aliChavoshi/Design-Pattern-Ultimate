namespace DesignPatterns.command.undoable;

public interface IUndoAbleCommand : ICommand
{
    void UnExecute();
}