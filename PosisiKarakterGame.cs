using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302210022
{
    internal class PosisiKarakterGame
    {
        public enum State
        {
            Berdiri,
            Jongkok,
            Tengkurap,
            Terbang
        }

        public enum Button
        {
            W,
            S,
            x
        }

        State kondisi;

        public PosisiKarakterGame()
        {
            kondisi = State.Berdiri;
            Console.WriteLine("Posisi Berdiri");
        }

        public void PBerdiri()
        {
            if(kondisi== State.Berdiri)
            {
                kondisi = State.Berdiri;
                Console.WriteLine("Posisi standby");
            }
        }

        public void PTengkurap()
        {
            if(kondisi== State.Berdiri)
            {
                kondisi= State.Tengkurap;
                Console.WriteLine("Posisi istirahat");
            }
        }


    }
}
