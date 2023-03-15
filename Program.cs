using static KodeBuah;

public class KodeBuah
{
    public enum NamaBuah
    {
        Apel,
        Aprikot,
        Alpukat,
        Pisang,
        Paprika,
        Blackberry,
        Ceri,
        Kelapa,
        Jagung,
        Kurma,
        Durian,
        Anggur,
        Melon,
        Semangka
    }

    public class getKode
    {
        public static string getKodeBuah(NamaBuah namaBuah)
        {
            string[] kodeList = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
            return kodeList[(int)namaBuah];
        }
    }
}
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