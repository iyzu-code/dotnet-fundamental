using System;

namespace VendingMachine;

public class Drink : Item
{
    public Drink(string name, decimal price, int quantity) : base(name, price, quantity)
    {
    }

    public override void Dispense()
    {
        Console.WriteLine("*CLUNK*... *Fizzing sound*... (Refreshing!)");
    }
}
