using System;

namespace Donguler
{
    class Program
    {
        //döngüler bir şeyi tekrarn etmek için kullanılır
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            string kurs2 = "Programlamay Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            //böyle tek tek yazmak yerine bunu dizilerde tanımlıyoruz
            //arraylerde yani dizilerde tutulur
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kursu", 
                "Programlamay Başlangıç İçin Temel Kurs", "Java","Python", "C#" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            //dizi temelli yapıları tek tek dönmeye yarar foreach
            foreach (string kurs in kurslar) //kursları dolaş demek //orda yazan kurs yazısına allias denir pythondaki gibi
            {
                Console.WriteLine(kurs);
            }

            //foreach ve for aynı şeyi yapar foreach daha kolay dolaşır sadece


            Console.WriteLine("Sayfa Sonu");
            Console.WriteLine("Sevgiler");

            //kendi örneğim
            string[] aile = new string[] {"anne", "baba", "kız çocuk", "erkek çocuk", "dede", "nine" };

            foreach (string x in aile)
            {
                Console.WriteLine(x);
            }

            //gerçek hayatta veriler sadece bir veriden oluşmaz birkeç bilgiden oluşur 
            
        }
    }
}
