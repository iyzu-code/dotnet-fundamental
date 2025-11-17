namespace BasicProgramming;

public class Audi : Car, IMachine
{
    public void Break()
    {
        Console.WriteLine("citttt");   
    }

    public void Move()
    {
        Console.WriteLine("ngengg");
    }

    public override void OpenDoor()
    {
        Console.WriteLine("Sliding");
    }

    public override void OpenWindow()
    {
        Console.WriteLine("Diputer");
    }
}
