namespace ConsoleApp1.command;

public class AddCustomerCommand : ICommand
{
    private readonly CustomerService _customerService;

    public AddCustomerCommand(CustomerService customerService)
    {
        _customerService = customerService;
    }

    public void Execute()
    {
        _customerService.AddCustomer();
    }
}