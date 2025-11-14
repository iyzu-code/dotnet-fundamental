namespace LearnOOP;

public class Math
{
    public int First;
    public int Second;

    // protected int plus_result;

    protected virtual int Plus()
    {
        return(this.First + this.Second);
    }
}

public class AfterPlus : Math
{
    public void divide()
    {
        // base.Plus();
        int divide_result = base.Plus()/base.Plus();
        Console.WriteLine($"Hasil bagi adlah: {divide_result}");
    }
}
