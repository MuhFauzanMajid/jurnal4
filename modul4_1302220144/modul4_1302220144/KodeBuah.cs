using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302220144
{
    public class KodeBuah
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
}
