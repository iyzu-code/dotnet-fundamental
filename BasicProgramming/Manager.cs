using System;

namespace BasicProgramming;

public class Manager<TId> : Employee<TId>
{
    public Manager(TId id) : base(id) { }

    public int Allowance { get; set; }

    public override void Introduction()
    {
        base.Introduction();
        Console.WriteLine("ALLOWANCE : " + Allowance);
    }
}
