using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Demet";
            musteri1.Soyad = "Çelik";
            musteri1.HesapNo = 1234567;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Nihat";
            musteri2.Soyad = "Yılmaz";
            musteri2.HesapNo = 8912546;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id:" + musteri.Id);
                Console.WriteLine("Müşteri Adı:" + musteri.Ad);
                Console.WriteLine("Müşteri Soyadı:" + musteri.Soyad);
                Console.WriteLine("Müşteri Hesap Numarası:" + musteri.HesapNo);
                Console.WriteLine();
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine();        
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            Console.WriteLine();
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
        }
    }
}
