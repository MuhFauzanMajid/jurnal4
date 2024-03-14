internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Testing KodeBuah");
        Console.WriteLine();
        KodeBuah kodeBuah = new KodeBuah();

        Console.Write("Masukkan nama buah : ");

        string input = Console.ReadLine();

        string kodeBuahinput = kodeBuah.getKodeBuah(input);

        if (kodeBuahinput == null)
        {
            Console.WriteLine("Kode buah untuk " + input + " tidak ditemukan.");
        }
        else
        {
            Console.WriteLine("Kode buah untuk " + input + ": " + kodeBuahinput);
        }
    }
}

class KodeBuah
{
    private static Dictionary<string, string> tabelKodeBuah = new Dictionary<string, string>
    {
        {"Apel", "A00"},
        {"Aprikot", "B00"},
        {"Alpukat", "C00"},
        {"Pisang", "D00"},
        {"Paprika", "E00"},
        {"Blackberry", "F00"},
        {"Ceri", "G00"},
        {"Kelapa", "H00"},
        {"Jagung", "I00"},
        {"Kurma", "K00"},
        {"Durian", "L00"},
        {"Anggur", "M00"},
        {"Melon", "N00"},
        {"Semangka", "O00"},
    };
    public string getKodeBuah(string buah)
    {
        if (tabelKodeBuah.ContainsKey(buah))
        {
            return tabelKodeBuah[buah];
        }
        else
        {
            return null; // atau bisa mengembalikan nilai lain jika kode pos tidak ditemukan
        }
    }
}
