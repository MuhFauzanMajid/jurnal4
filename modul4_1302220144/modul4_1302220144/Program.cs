internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Testing KodeBuah\n");
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
        Console.WriteLine("\nTesting Posisi Karakter Game\n");
        PosisiKarakterGame posisi = new PosisiKarakterGame();
        posisi.TombolW();
        posisi.TombolX();
        posisi.TombolS();
        posisi.TombolW();
        posisi.TombolW();
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

class PosisiKarakterGame
{
    private Posisi currentState;

    public PosisiKarakterGame()
    {
        currentState = Posisi.Berdiri;
        Console.WriteLine("Posisi Default berdiri");
    }
    
    enum Posisi
    {
        Tengkurap,
        Jongkok,
        Berdiri,
        Terbang
    }
    public void TombolS()
    {
        if (currentState == Posisi.Jongkok)
        {
            currentState = Posisi.Tengkurap;
            Console.WriteLine("Posisi berubah menjadi tengkurap");
            Console.WriteLine("Posisi istirahat");
        }
        else if (currentState == Posisi.Terbang)
        {
            currentState = Posisi.Berdiri;
            Console.WriteLine("Posisi berubah menjadi berdiri");
            Console.WriteLine("Posisi standby");
        }
        else if (currentState == Posisi.Berdiri)
        {
            currentState = Posisi.Jongkok;
            Console.WriteLine("Posisi berubah menjadi jongkok");
        }
    }
    public void TombolX()
    {
        if(currentState == Posisi.Terbang)
        {
            currentState = Posisi.Jongkok;
            Console.WriteLine("Posisi berubah menjadi jongkok");
        }
    }
    public void TombolW()
    {
        if (currentState == Posisi.Tengkurap)
        {
            currentState = Posisi.Jongkok;
            Console.WriteLine("Posisi berubah menjadi jongkok");
        }
        else if (currentState == Posisi.Jongkok)
        {
            currentState = Posisi.Berdiri;
            Console.WriteLine("Posisi berubah menjadi berdiri");
            Console.WriteLine("Posisi standby");
        }
        else if (currentState == Posisi.Berdiri)
        {
            currentState = Posisi.Terbang;
            Console.WriteLine("Posisi berubah menjadi terbang");
        }
    }
}