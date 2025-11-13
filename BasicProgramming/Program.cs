namespace BasicProgramming;

class Program
{
    static void Main(string[] args)
    {
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
        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }

        // int i = 1;
        // while (i < 10)
        // {
        //     Console.WriteLine("loop" + i);
        //     i++;
        // }
    }    
}