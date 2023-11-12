using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class MusteriManager
    {
        Musteri[] musteriler = new Musteri[] {};
        public void ekle()
        {
            Console.WriteLine("Musteri Eklendi...!");
        }
        public void sil() 
        {
            Console.WriteLine("Müsteri Silindi...!");
        }
        public void listele()
        {
            Console.WriteLine("Müsteri Listesi...!");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Adı: " + musteri.Ad);
                Console.WriteLine("SoyAdı: " + musteri.Soyad);
                Console.WriteLine("Telefonu: " + musteri.Telefon);
                Console.WriteLine("---------");
            }
        }
    }
}
