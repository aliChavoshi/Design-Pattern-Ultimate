namespace ConsoleApp1.command;

public class DeleteCustomerCommand : ICommand
{
    private readonly CustomerService _customerService;

    public DeleteCustomerCommand(CustomerService customerService)
    {
        _customerService = customerService;
    }

    public void Execute()
    {
        _customerService.DeleteCustomer();
    }
}