namespace BasicProgramming;

class Program
{
    static void Main(string[] args)
    {
        Employee<string> ahmad = new Employee<string>("1000");
        var theo = new Employee<int>(100);

        ahmad.FullName = "Ahmad Izzuddin";
        ahmad.Id = "string-901036";
        ahmad.Job = "Selebgram";
        ahmad.Salary = 5.300f;

        Employee<int> imam = new Employee<int>(1001);

        imam.FullName = "Imam Besar";
        imam.Id = 901033;
        imam.Job = "Tiktoker";
        imam.Salary = 5.600f;

        // ahmad.Introduction();
        // imam.Introduction();

        Manager<string> joko = new Manager<string>("1002");
        joko.FullName = "Pak Joko";
        joko.Allowance = 5;
        joko.Salary = 100;
        joko.Job = "Technical Consultant Manager";

        // joko.Introduction();
        // joko.Calculate(joko.Allowance);

        // Console.WriteLine(joko.Allowance);
        // Console.WriteLine(joko.Calculate(joko.Allowance));

        List<Employee<int>> employees = new List<Employee<int>>();

        employees.Add(new Employee<int>(2000)
        {
            FullName = "Sigma",
            Job = "Backend Developer",
            Salary = 8.500f
        });
        
        employees.Add(new Employee<int>(2000)
        {
            FullName = "Sigma",
            Job = "Backend Developer",
            Salary = 8.500f
        });

        // foreach (var i in employees)
        // {
        //     i.Introduction();
        // }

        Dictionary<string, Employee<int>> employees2 = new Dictionary<string, Employee<int>>();
        employees2.Add("Hero", new Employee<int>(99)
        {
            FullName = "Sigma",
            Job = "Backend Developer",
            Salary = 8.500f
        });

        employees2["Hero"].Introduction();
        // foreach (var i in employees2)
        // {
        //     i.Value.Introduction();
        // }
    }    
}


// class Program
// {
//     static void Main(string[] args)
//     {
//         // Audi a8 = new Audi();
//         // a8.IsManual = true;
//         // a8.MaxGear = 10;
//         // a8.TopSpeed = 200;

//         // Console.WriteLine($"{a8.IsManual} : {a8.MaxGear} : {a8.TopSpeed}");

//         // a8.OpenDoor();
//         // a8.OpenWindow();
//         // a8.Break();
//         // a8.Move();

//         BMW m4 = new BMW();
//         m4.IsManual = false;
//         m4.MaxGear = 10;
//         m4.TopSpeed = 350;

//         Console.WriteLine($"{m4.IsManual} : {m4.MaxGear} : {m4.TopSpeed}");

//         m4.OpenDoor();
//         m4.OpenWindow();
//         m4.Break();
//         m4.Move();

//         IMachine m3 = new BMW();
//         m3.Move();
//     }
// }
