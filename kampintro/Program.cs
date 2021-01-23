using System;

namespace kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategorietiketi = "kategori";
            int ogrenciSayisi = 100000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");

            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");

            }

            string senaKaplan = "Sena Kaplan";
            Console.WriteLine(senaKaplan);

            int yas = 19;
            Console.WriteLine(yas);

            //şart blokları
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }

            else
            {
                Console.WriteLine("Değişmedi Butonu");

            }

        }
    }
}


