using System;

namespace VendingMachine;

public class Chip : Item
{
    public Chip(string name, decimal price, int quantity) : base(name, price, quantity)
    {
    }

    public override void Dispense()
    {
        Console.WriteLine("Rattle*Rattle*... *Crunch*... (Salty goodness!)");
    }
}
