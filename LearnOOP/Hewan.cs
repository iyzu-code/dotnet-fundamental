namespace LearnOOP;

public class Hewan
{
    public string Nama;

    public Hewan(string nama)
    {
        Nama = nama;
    }
    public virtual void Makan()
    {
        Console.WriteLine($"{Nama} sedang makan");
    }
}

public class Kucing : Hewan
{
    public Kucing(string nama) : base(nama)
    {
    }

    public override void Makan()
    {
        base.Makan();
        Console.WriteLine($"akhirnya {Nama} kenyany");
    }
}