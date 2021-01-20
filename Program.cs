using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Orhan";
            musteri1.MusteriSoyadi = "Acar";
            musteri1.MusteriTel = "0123456789";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Ali";
            musteri2.MusteriSoyadi = "veli";
            musteri2.MusteriTel = "02469788533";
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriListeleme(musteri1);
            musteriManager.MusteriSilme(musteri2);
        }
    }
}
