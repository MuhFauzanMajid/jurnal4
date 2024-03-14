using modul4_1302220144;

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



