using System;

namespace VendingMachine;

public abstract class Item
{
    public String Name { get; protected set; }
    public Decimal Price { get; protected set; }
    public int Quantity { get; set; }

    protected Item(string name, Decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
    
    public abstract void Dispense();
}
