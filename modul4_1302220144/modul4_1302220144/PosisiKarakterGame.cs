using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302220144
{
    public class PosisiKarakterGame
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
            if (currentState == Posisi.Terbang)
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
}
