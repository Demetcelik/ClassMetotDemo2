using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi:" + musteri.HesapNo);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi:" + musteri.HesapNo);
        }
        public void Listele(Musteri musteri) 
        {
            Console.WriteLine("Müşteriler Listelendi:" + musteri.HesapNo);
        }
    }
}
