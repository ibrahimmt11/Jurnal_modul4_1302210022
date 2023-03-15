using modul4_1302210022;
using static modul4_1302210022.KodeBuah;
using static modul4_1302210022.PosisiKarakterGame;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Table Driven ===");
        getKode kodeBuah= new getKode();
        NamaBuah buah = NamaBuah.Apel;
        string kode = getKode.getKodeBuah(buah);
        Console.WriteLine(buah + ": " + kode);

        Console.WriteLine("=== State-base ===");
        PosisiKarakterGame orang = new PosisiKarakterGame();
        orang.PBerdiri();
        orang.PTengkurap();
    }
}