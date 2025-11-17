namespace BasicProgramming;

public class BMW : Car, IMachine
{
    public void Break()
    {
        Console.WriteLine("citttt");
    }

    public void Move()
    {
        Console.WriteLine("ngennggg");
    }

    public override void OpenDoor()
    {
        Console.WriteLine("ngikkk");
    }

    public override void OpenWindow()
    {
        Console.WriteLine("krekkk");
    }
}
