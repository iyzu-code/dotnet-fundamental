using System;

namespace VendingMachine;

public class Candy : Item
{
    public Candy(string name, decimal price, int quantity) : base(name, price, quantity)
    {
    }

    public override void Dispense()
    {
        Console.WriteLine("*Thud*... (Sweet treat acquired!)");
    }
}
