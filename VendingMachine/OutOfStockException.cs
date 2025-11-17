using System;

namespace VendingMachine;

public class OutOfStockException : Exception
{
    public OutOfStockException()
    {
    }

    public OutOfStockException(string message) : base(message)
    {
    }
}
