namespace BasicProgramming;

public class Employee<TId>
{
    public Employee(TId id)
    {
        Id = id;
    }

    public TId Id { get; set; }
    // public string fullName;
    public string FullName { get; set; }
    // private float salary;
    public float Salary { get; set; }
    // public string job;
    public string Job { get; set; }

    public virtual void Introduction()
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("ID : " + Id);
        Console.WriteLine("NAME : " + FullName);
        Console.WriteLine("SALARY : " + Salary);
        Console.WriteLine("JOB : " + Job);
        Console.WriteLine("=====================================");
        Console.WriteLine("");
    }

    public float Calculate()
    {
        float tax = 2.5f;
        return Salary * tax;
    }

    public float Calculate(int Allowance)
    {
        float tax = 2.5f;
        return Salary * tax * Allowance;
    }
}
