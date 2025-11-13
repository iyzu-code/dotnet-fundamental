using Microsoft.VisualBasic;

namespace OddEvenApp;

class Program
{
    /*
     * Menampilkan Menu
     */
    static void Menu()
    {
        bool loop = true;
        while (loop == true)
        {
            Console.WriteLine("");
            Console.WriteLine("=====================================");
            Console.WriteLine("           MENU GANJIL GENAP");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. Cek Ganjil Genap");
            Console.WriteLine("2. Print Ganjil/Genap (dengan limit)");
            Console.WriteLine("3. Exit");
            Console.WriteLine("-------------------------------------");

            Console.Write("Pilihan: ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Masukkan Bilangan yang ingin di cek: ");
                    try
                    {
                        int input_angka = int.Parse(Console.ReadLine() ?? "");
                        Console.WriteLine(CheckEvenOrOdd(input_angka));
                    }
                    catch
                    {
                        Console.WriteLine("Masukin angka kocak");
                    }
                    break;

                case "2":
                    Console.Write("Pilih (Ganjil/Genap): ");
                    var pilihan = Console.ReadLine();

                    try
                    {
                        Console.Write("Masukkan limit: ");
                        var limit = int.Parse(Console.ReadLine() ?? "");
                        
                        Console.WriteLine("Print bilangan 1 - " + limit + " yang " + pilihan + " - " + pilihan + " aja");
                        
                        PrintEvenOdd(limit, pilihan ?? "");
                    }
                    catch
                    {
                        Console.WriteLine("Masukin angka kocak");
                    }
                    break;

                case "3":
                    Console.WriteLine("Selesai");
                    loop = false;
                    break;
                
                default:
                    Console.WriteLine("Salah input kocak");
                    break;
            }            
        }
    }

    /*
     * ex: PrintEvenOdd(5, "Genap"') ;
     * output 1, 3, 5
     * x: PrintEvenOdd(5, "Ganjil");
     * output 2, 4
     * @PARAM Limit: Batas akhir. minimal 1, tidak boleh O atau negatif.
     * @PARAM choice: Pilihan, hanya boleh "Even" atau "Odd". Selain itu invalid
     */
    static void PrintEvenOdd(int limit, string choice)
    {
        if (choice == "Genap" && limit > 1)
        {
            // Console.WriteLine("Genap");
            var hasil = "";
            for (int i = 1; i < limit; i++)
            {
                if (i % 2 == 0)
                {
                    hasil += i + ", ";
                }
            }
            var hasil_akhir = "";
            for (int i = 0; i < hasil.Length-2; i++)
            {
                hasil_akhir += hasil[i];
            }
            Console.WriteLine(hasil_akhir);
        }
        else if (choice == "Genap" && limit >= 1)
        {
            Console.WriteLine("Mikir Kids");
        }
        else if (choice == "Ganjil" && limit > 0)
        {
            // Console.WriteLine("Ganjil");
            var hasil = "";
            for (int i = 0; i < limit; i++)
            {
                if (i % 2 != 0)
                {
                    hasil += i + ", ";
                }
            }
            var hasil_akhir = "";
            for (int i = 0; i < hasil.Length-2; i++)
            {
                hasil_akhir += hasil[i];
            }
            Console.WriteLine(hasil_akhir);
        }
        else if (choice != "Ganjil" && choice != "Genap")
        {
            Console.WriteLine("Salah input ganjil genap kocak");
        }
        else if (limit <= 0)
        {
            Console.WriteLine("Salah input angka kocak");
        }
        else
        {
            Console.WriteLine("Salah input kocak");
        }

    }

    /*
     * ex: EvenOddCheck(5);
     * output "Even"
     * @PARAM input: Angka yang akan dicek. minimal 1, tidak boleh O atau negatif.
     * @RETURN "Genap" jika input genap, "Ganil". jika input ganjil, selain itu Invalid Input!! jika input tidak sesuai pada @PARAM input
     */
    static string CheckEvenOrOdd(int input)
    {
        if (input % 2 == 0 && input > 0)
        {
            return "Genap";
        } 
        else if (input % 2 != 0 && input > 0)
        {
            return "Ganjil";
        }
        else
        {
            return "Salah input kocak";
        }
    }
    
    static void Main(string[] args)
    {
        Menu();
    }
}