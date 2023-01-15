namespace DesignPatterns.template;

public class TransferMoneyTask : Task
{
    private protected override void DoExecute()
    {
        Console.WriteLine("Transfer money task ...");
    }
}