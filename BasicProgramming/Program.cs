namespace BasicProgramming;

class Program
{
    static string FullName(string firstName, string lastName)
    {
        return "Ahmad";
    }

    static int Age()
    {
        return 22;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Name: " + FullName("a", "b"));
        Console.WriteLine("Age: " + Age());

        int age = 17;
        var status = "no status";
        string name = "Ahmad";

        age += 1;

        if (age == 0)
        {
            name = "belum diberi nama";
            status = "baru lahir";
        }

        switch (age)
        {
            case 0:
                status = "baru lahir";
                break;
            case > 10:
                break;
            default:
                break;
        }

        // Console.WriteLine(name);
        // Console.WriteLine("Age: " + age);
        // Console.WriteLine(status);

        //looping
        // for (int i = 0; i <= 5; i++)
        // {
        //     if (i % 2 != 0)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }

        // int i = 1;
        // while (i < 10)
        // {
        //     Console.WriteLine("loop" + i);
        //     i++;
        // }

        string [] fams = ["ivy", "faixvey", "iyzu"];

        // foreach (string fam in fams)
        // {
        //     // Console.ReadLine();
        //     Console.WriteLine(fam);
        // }
    }    
}