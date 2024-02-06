using System;

class Program
{
    static void Main(string[] args)
    {
        // jmlh per jenis
        int jumlahRuby = 5;
        int jumlahTopaz = 3;
        int jumlahPermata = 1;

        // harga per psg
        int hargaRuby = 1000000;
        int hargaTopaz = 1250000;
        int hargaPermata = 3000000;

        // hitung pendapatan max
        int pendapatanMaksimum = CalculateMax(jumlahRuby, jumlahTopaz, jumlahPermata, hargaRuby, hargaTopaz, hargaPermata);

        Console.WriteLine("Maksimum pendapatan Rp " + pendapatanMaksimum);
    }

    static int CalculateMax(int jumlahRuby, int jumlahTopaz, int jumlahPermata, int hargaRuby, int hargaTopaz, int hargaPermata)
    {
        // Hitung jumlah pasang tiap jenis
        int pasangRuby = jumlahRuby / 2;
        int pasangTopaz = jumlahTopaz / 2;
        int pasangPermata = jumlahPermata / 2;

        // Hitung pendapatan dari tiap jenis
        int pendapatanRuby = pasangRuby * hargaRuby;
        int pendapatanTopaz = pasangTopaz * hargaTopaz;
        int pendapatanPermata = pasangPermata * hargaPermata;

        // Total pendapatan max
        int totalPendapatan = pendapatanRuby + pendapatanTopaz + pendapatanPermata;

        return totalPendapatan;
    }
}
