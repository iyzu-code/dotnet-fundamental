namespace LearnOOP;

class Program
{
    static void Main(string[] args)
    {
        // Kucing persia = new Kucing("Ezy");
        // // persia.Nama = "Eve";
        // persia.Makan();
        // // persia.Nyaa();

        AfterPlus calc = new AfterPlus();
        calc.First = 10;
        calc.Second = 20;
        calc.divide();
    }
}









































/* ######################  SECTION 2  ########################### */

// namespace LearnOOP
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             AkunBank rekening1 = new AkunBank();
//             AkunBank rekening2 = new AkunBank();

//             // rekening.Level = 100;
//             // Console.WriteLine(rekening1.Level);
//             // Console.WriteLine(rekening1.Saldo);

//             rekening1.Setor(10000);
//             rekening1.Setor(10000);

//             rekening1.Tarik(5000);

//             Console.WriteLine(rekening1.Saldo);
//             Console.WriteLine(rekening2.Saldo);
//         }
//     }
// }

// public class AkunBank
// {
//     // tidak bisa dibaca dan diedit dari luar
//     private decimal saldo;

//     // bisa dibaca dari luar tetapi tidak bisa diedit dari luar
//     public int Level { get; private set; }

//     //bisa dibaca dan diedit dari luar
//     public int Poin {get; set; }

//     public decimal Saldo
//     {
//         get { return saldo; }
//         private set { saldo = value; }
//     }

//     public void Setor(decimal jumlah_setor)
//     {
//         saldo += jumlah_setor;
//     }

//     public void Tarik(decimal jumlah_tarik)
//     {
//         saldo -= jumlah_tarik;
//     }

// }




/* ######################  SECTION 1  ########################### */

// namespace LearnOOP
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Mobil m1 = new Mobil();
//             m1.Merek = "BMW M4 Competition";
//             m1.Tahun = 2025;

//             m1.Jalan();
//         }
//     }
// }

// public class Mobil
// {
//     public string Merek;
//     public int Tahun;

//     public void Jalan()
//     {
//         Console.WriteLine($"{Merek} tahun {Tahun} sedang berjalan.");
//     }
// }

