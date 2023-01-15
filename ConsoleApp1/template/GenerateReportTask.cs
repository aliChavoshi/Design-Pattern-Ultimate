namespace DesignPatterns.template;

public class GenerateReportTask : Task
{
    private protected override void DoExecute()
    {
        Console.WriteLine("Generate report task...");
    }
}