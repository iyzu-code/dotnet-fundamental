namespace VendingMachine;

public class UnknownCommandException : Exception
{
    public UnknownCommandException()
    {
    }

    public UnknownCommandException(string message) : base(message)
    {
        
    }
}
