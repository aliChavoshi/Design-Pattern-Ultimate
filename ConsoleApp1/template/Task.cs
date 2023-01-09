namespace ConsoleApp1.template;

public abstract class Task
{
    private readonly AuditTrail _auditTrail;

    protected Task()
    {
        _auditTrail = new AuditTrail();
    }

    public void Execute()
    {
        _auditTrail.Record();
        DoExecute();
    }

    private protected abstract void DoExecute();
}