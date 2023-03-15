using static modul4_1302210022.KodeBuah;

class Program
{
    private static void Main(string[] args)
    {
        getKode kodeBuah= new getKode();
        NamaBuah buah = NamaBuah.Apel;
        string kode = getKode.getKodeBuah(buah);
        Console.WriteLine(buah + ": " + kode);

    }
}