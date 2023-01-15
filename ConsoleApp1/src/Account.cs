namespace DesignPatterns;

public class Account
{
    private float _balanced;

    public float GetBalanced()
    {
        return _balanced;
    }

    public void Deposit(float amount)
    {
        if (amount > 0)
            _balanced += amount;
    }

    public void Withdraw(float amount)
    {
        if (amount > 0)
            _balanced -= amount;
    }
}