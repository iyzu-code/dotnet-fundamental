/*
 * BAGIAN 1: Berisi semua Pengecualian (Exception) kustom kita.
 * TUJUAN: Agar kita bisa membedakan error (e.g., "uang kurang" vs "stok habis") di dalam blok 'try-catch' nanti.
 */

// ? DONE
/*
 * TODO: Buat Kustom Exception (Custom Exceptions)
 *
 * 1. Buat sebuah class public baru bernama 'OutOfStockException'.
 * - @INHERIT: Class ini HARUS mewarisi (inherit) dari 'Exception'.
 * - @CONSTRUCTOR: Buat sebuah constructor public yang menerima satu 'string message'.
 * - @LOGIC: Di dalam constructor, panggil constructor 'base(message)'.
 *
 * 2. Buat sebuah class public baru bernama 'InsufficientFundsException'.
 * - @INHERIT: Class ini HARUS mewarisi (inherit) dari 'Exception'.
 * - @CONSTRUCTOR: Buat sebuah constructor public yang menerima satu 'string message'.
 * - @LOGIC: Di dalam constructor, panggil constructor 'base(message)'.
 */

// ===============================================================================================


// ? ONGOING
/*
 * BAGIAN 2: 'Item' (abstract)
 * TUJUAN: Blueprint untuk semua item yang bisa dijual.
 * Kelas ini tidak boleh di-instantiate langsung (Abstract).
 * Kelas lain (Drink, Chip, Candy) HARUS mewarisi (inherit) dari sini.
 */

/*
 * TODO: Buat Abstract Class 'Item'
 *
 * 1. Buat class public abstract bernama 'Item'.
 *
 * 2. Definisikan Properties berikut di dalam class:
 * - Property 'Name': Tipe string. Getter public, Setter protected.
 * - Property 'Price': Tipe decimal. Getter public, Setter protected.
 * - Property 'Quantity': Tipe int. Getter public, Setter public.
 *
 * 3. Buat Constructor Protected:
 * - @ACCESS: protected (karena class ini abstract, hanya child yang boleh memanggilnya).
 * - @PARAM: string name, decimal price, int quantity.
 * - @LOGIC: Tetapkan nilai parameter ke properti yang sesuai (this.Name = name, dst).
 *
 * 4. Buat Abstract Method 'Dispense': (tidak ada bodynya)
 * - @ACCESS: public abstract.
 * - @RETURN: void.
 * - @LOGIC: Method ini TIDAK memiliki body (gunakan tanda titik koma ';').
 * Ini memaksa kelas turunan untuk mendefinisikan cara 'Dispense' mereka sendiri.
 */

/*
 * BAGIAN 2.1: Implementasi konkret dari 'Item'.
 * TUJUAN: Inherit 'Item' dan menyediakan implementasi 'override' untuk metode 'Dispense()'.
 */

/*
 * TODO: Buat Class 'Drink', 'Chip', dan 'Candy'
 *
 * Ulangi langkah-langkah berikut untuk membuat TIGA class terpisah (Drink, Chip, dan Candy):
 *
 * 1. Definisi Class:
 * - Buat class public (misalnya 'public class Chip').
 * - @INHERIT: Class ini HARUS inherit dari class 'Item'.
 *
 * 2. Buat Constructor:
 * - @ACCESS: public.
 * - @PARAMS: Menerima (string name, decimal price, int quantity).
 * - @LOGIC: Panggil constructor parent/base menggunakan syntax 'base'.
 * Body constructor biarkan kosong saja.
 *
 * 3. Override Method 'Dispense':
 * - @ACCESS: public override void.
 * - @LOGIC: Gunakan 'Console.WriteLine' untuk menampilkan suara/pesan unik item tersebut.
 * - Contoh Chip: "*Rattle*... *Crunch*..."
 * - Contoh Candy: "*Thud*... (Sweet!)"
 * - Contoh Drink: "*Glug glug*... *Fizz*"
 */
// ===============================================================================================

/*
 * BAGIAN 3: VendingMachine (logic business)
 * TUJUAN: Kelas inti (engine/core) yang menampung semua logika bisnis.
 * PRINSIP: Encapsulation. State internal (_inventory, _currentBalance) HARUS 'private'.
 */

/*
 * TODO: Buat Class 'VendingMachine'
 *
 * 1. Buat class public bernama 'VendingMachine'.
 *
 * 2. Definisikan Fields yang hanya bisa diakses internal:
 * - Field '_inventory': Private. Tipe 'Dictionary<string, Item>'.
 * - Field '_currentBalance': Private. Tipe 'decimal'.
 *
 * 3. Definisikan Public Property:
 * - Property 'CurrentBalance': Public, Tipe 'decimal'.
 * - Hanya boleh memiliki 'get' (read-only) yang mengembalikan nilai '_currentBalance'.
 *
 * 4. Buat Constructor:
 * - @ACCESS: public.
 * - @LOGIC:
 * a. Inisialisasi memori untuk '_inventory' (new Dictionary...).
 * b. Panggil method private 'InitializeInventory()'.
 *
 * 5. Buat Method Helper 'InitializeInventory':
 * - @ACCESS: private void.
 * - @LOGIC: Isi '_inventory' dengan data dummy.
 * Gunakan method '.Add("Kode", new ObjectItem(...))'.
 * Contoh: _inventory.Add("A1", new Drink("Cola", 1.50m, 5));
 * PENTING: Buat setidaknya satu item dengan quantity 0 untuk mengetes error 'OutOfStock'.
 * Masukkan data berikut persis seperti ini:
 * 5.1. Kategori Minuman (Drink):
 * - Kode "A1" -> Nama: "Cola", Harga: 1.50, Stok: 5
 * - Kode "A2" -> Nama: "Water", Harga: 1.00, Stok: 8
 * 5.2. Kategori Keripik (Chip):
 * - Kode "B1" -> Nama: "Chips", Harga: 1.25, Stok: 3
 * - Kode "B2" -> Nama: "Pretzels", Harga: 1.25, Stok: 4
 * 5.3. Kategori Permen (Candy):
 * - Kode "C1" -> Nama: "Candy Bar", Harga: 0.75, Stok: 0
 * - Kode "C2" -> Nama: "Gum", Harga: 0.50, Stok: 10
 *
 * 6. Buat Method 'GetInventory':
 * - @ACCESS: public Dictionary<string, Item>.
 * - @RETURN: Mengembalikan field '_inventory'.
 *
 * 7. Buat Method 'InsertMoney':
 * - @ACCESS: public void.
 * - @PARAM: decimal amount.
 * - @LOGIC:
 * a. Validasi: Jika 'amount' <= 0, lempar 'ArgumentException' dengan pesan error.
 * b. Jika valid, tambahkan 'amount' ke '_currentBalance'.
 *
 * 8. Buat Method 'Refund':
 * - @ACCESS: public decimal.
 * - @LOGIC:
 * a. Simpan nilai '_currentBalance' ke variabel sementara.
 * b. Ubah '_currentBalance' menjadi 0.
 * c. Return variabel sementara tadi (uang kembalian).
 *
 * 9. Buat Method UTAMA 'PurchaseItem':
 * - @ACCESS: public decimal.
 * - @PARAM: string selectionCode.
 * - @RETURN: decimal (sisa saldo setelah pembelian).
 * - @LOGIC (Langkah-langkah PENTING):
 * 9.1. Cek Kode: Apakah '_inventory' memiliki key 'selectionCode'? Jika TIDAK: Lempar 'KeyNotFoundException'.
 * 9.2. Ambil Item: Ambil item dari dictionary (misal: 'var item = _inventory[selectionCode]').
 * 9.3. Cek Stok: Apakah 'item.Quantity' <= 0? Jika YA: Lempar 'OutOfStockException' (Exception kustom yang Anda buat).
 * 9.4. Cek Uang: Apakah '_currentBalance' < 'item.Price'? Jika YA: Lempar 'InsufficientFundsException' (Exception kustom yang Anda buat).
 * 9.5. PROSES TRANSAKSI (Jika semua lolos):
 * - Kurangi '_currentBalance' dengan harga item.
 * - Kurangi 'item.Quantity' sebanyak 1.
 * - Tambah code berikut Console.WriteLine($"\n  [Dispensing]: {selectedItem.Name}");
 * - Panggil 'item.Dispense()' (Disinilah Polymorphism terjadi!).
 * 9.6. Return '_currentBalance' (sisa uang).
 */

// ===============================================================================================


/*
 * BAGIAN 4: Program
 * TUJUAN: UI (User Interface) Layer. Hanya bertanggung jawab untuk:
 * 1. Menampilkan UI (via DrawUI).
 * 2. Menerima input user.
 * 3. Memanggil VendingMachine (engine/core).
 * 4. Menangani (catch) semua exception dari VendingMachine.
 */

//  candy, chip, drink, 2 ex, item, VendingMachine, program
using VendingMachine;

class Program
{
    /*
     * @METHOD Main(string[] args)
     * @DESCRIPTION Titik awal program. Berisi "Game Loop" utama (while true).
     */
    static void Main(string[] args)
    {
        // TODO: Inisialisasi VendingMachine disini
        string statusMessage = ""; // Untuk menyimpan pesan error/sukses
        VendingMachine.VendingMachine vm = new VendingMachine.VendingMachine();

        while (true)
        {
            // TODO: Panggil DrawUI(vm, statusMessage);
            DrawUI(vm, statusMessage);

            statusMessage = ""; // Reset pesan setiap loop

            Console.Write("ENTER COMMAND: ");
            string input = Console.ReadLine() ?? "input kosong";

            if (string.IsNullOrWhiteSpace(input)) continue;

            string[] parts = input.Split(' ');
            string command = parts[0].ToLower();
            string argument = parts.Length > 1 ? parts[1].ToUpper() : "";

            /*
             * BAGIAN INI: Logika Pemrosesan Perintah & Error Handling
             */

            /*
             * TODO: Implementasi Logika Transaksi (Try-Catch & Switch)
             *
             * 1. Mulai Blok 'try':
             * Bungkus seluruh logika switch-case di bawah ini ke dalam blok 'try'.
             * Ini wajib agar kita bisa menangkap error dari VendingMachine.
             *
             * 2. Buat Switch Statement (berdasarkan variabel 'command'):
             *
             ? CASE "insert":
             * - Logika: User ingin memasukkan uang.
             * - Langkah:
             * a. Parsing string 'argument' menjadi tipe decimal (gunakan decimal.Parse).
             * b. Panggil method untuk menambahkan uang di vending machine
             *
             ? CASE "select":
             * - Logika: User ingin membeli item.
             * - Langkah:
             * a. Panggil method untuk membeli item di vending machine.
             * b. Tampilkan pesan sukses/saldo sisa, lalu 'Console.ReadLine()' untuk jeda.
             *
             ! CASE "refund":
             * - Logika: User meminta uang kembali.
             * - Langkah:
             * a. Panggil method refund di vending machine
             * b. Tampilkan jumlah uang yang dikembalikan ke user.
             * c. Beri jeda (Console.ReadLine).
             *
             * CASE "quit":
             * - Logika: Keluar program.
             * - Langkah: Panggil 'return;' (ini akan menghentikan method Main).
             *
             * DEFAULT:
             * - Logika: User mengetik perintah aneh.
             * - Langkah: Set variabel 'statusMessage' = "Perintah tidak dikenal".
             *
             * 3. Buat Blok 'catch' (Multiple Catch):
             * Setelah blok 'try' selesai, buatlah serangkaian blok 'catch' untuk menangkap exception.
             * Di dalam setiap catch, set variabel 'statusMessage' dengan pesan error (ex.Message).
             *
             * - catch (InsufficientFundsException ex): Untuk error uang kurang.
             * - catch (OutOfStockException ex): Untuk error stok habis.
             * - catch (KeyNotFoundException ex): Untuk error kode item salah (misal pilih "Z9").
             * - catch (FormatException ex): Untuk error parsing angka (misal insert "abc").
             * - catch (Exception ex): "Catch-all" untuk error sistem yang tidak terduga.
             */

            try
            {
                switch (command)
                {
                    case "insert":
                        decimal amount = decimal.Parse(argument);
                        vm.InsertMoney(amount);
                        break;
                    case "select":
                        vm.PurchaseItem(argument);
                        Console.Read();
                        break;
                    case "refund":
                        Console.WriteLine($"Kembalian : {vm.Refund()}");
                        Console.Read();
                        break;
                    case "quit":
                        return;
                    default:
                        Console.WriteLine("Perintah tidak dikenal");
                        Console.Read();
                        break;
                }
            }
            catch (InsufficientFundsException ex)
            {
                statusMessage = ex.Message;
            }
            catch (OutOfStockException ex)
            {
                statusMessage = ex.Message;
            }
            catch (KeyNotFoundException ex)
            {
                statusMessage = ex.Message;
            }
            catch (FormatException ex)
            {
                statusMessage = ex.Message;
            }
            catch (Exception ex)
            {
                statusMessage = ex.Message;
            }
        }
    }

    /*
     * @METHOD DrawUI(VendingMachine vm, string message)
     * @DESCRIPTION Menggambar seluruh "layar" UI di konsol.
     * @PARAM vm: Objek VendingMachine untuk mengambil inventory dan saldo.
     * @PARAM message: Pesan error atau status untuk ditampilkan di atas.
     */
    static void DrawUI(VendingMachine.VendingMachine vm, string message)
    {
        Console.Clear();
        Console.WriteLine("=====================================================");
        Console.WriteLine("===          THE OOP VENDING MACHINE              ===");
        Console.WriteLine("=====================================================");
        Console.WriteLine("");

        // Print Status Message (Red if error)
        if (!string.IsNullOrEmpty(message))
        {
            if (message.Contains("ERROR")) Console.ForegroundColor = ConsoleColor.Red;
            else Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"  {message}");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // Print Inventory
        foreach (var entry in vm.GetInventory())
        {
            string code = entry.Key;
            Item item = entry.Value;

            // Formatting: {0,-5} means align left 5 spaces
            string stockDisplay = item.Quantity > 0 ? $"[Qty: {item.Quantity}]" : "[SOLD OUT]";

            // Visual cue: Gray out the sold out items
            if (item.Quantity == 0) Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine($"  [{code}] {item.Name,-12} (${item.Price:0.00}) {stockDisplay}");

            Console.ResetColor();
        }

        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine($"  CURRENT BALANCE: ${vm.CurrentBalance:0.00}");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("  COMMANDS:");
        Console.WriteLine("    > insert [amount]  (e.g., 'insert 1.50')");
        Console.WriteLine("    > select [code]    (e.g., 'select A1')");
        Console.WriteLine("    > refund           (Get your money back)");
        Console.WriteLine("    > quit             (Exit the program)");
        Console.WriteLine("");
    }
}
