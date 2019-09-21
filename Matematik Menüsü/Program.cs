using System;

namespace Matematik_Menüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            int islem;
            Console.WriteLine("Aritmetik İşlemler Menüsüne Hoşgeldiniz..");
            Console.WriteLine();
            Console.WriteLine("*******Menü*********\n");
            Console.WriteLine("1-Aritmetik dört işlem");
            Console.WriteLine("2- Üs alma");
            Console.WriteLine("3- Kök Alma");
            Console.WriteLine("4-Karenin çevre ve alan hesabı");
            Console.WriteLine("5-Dikdörtgenin alan ve çevre hesabı");
            Console.WriteLine("6-Eşkenaer üçgende Çevre");

            Console.WriteLine("**************************\n");

            Console.WriteLine("İşlem yapmak istediğiniz alan: ");
            islem = Convert.ToInt32(Console.ReadLine());

            if (islem == 1)
            {
                int a, b, toplam, fark, carpim; 
                Console.Write("1. sayıyı Giriniz: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. sayıyı Giriniz: ");
                b = Convert.ToInt32(Console.ReadLine());
                toplam = a + b;
                fark = a - b;
                carpim = a * b;
                Console.WriteLine("Toplam: " + toplam);
                Console.WriteLine("Fark: " + fark);
                Console.WriteLine("Carpim: " + carpim);
                Console.WriteLine("Bolüm: " + (float)a/b);

            }
            if (islem == 2)
            {
                double sayi, us, sonuc;
                Console.WriteLine("Sayıyı Girin: ");
                sayi = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("üssü giriniz: ");
                us = Convert.ToDouble(Console.ReadLine());
                sonuc = Math.Pow(sayi, us);
                Console.WriteLine("sonuc: " + sonuc);
            }

            if (islem == 3)
            {
                double sayi, kok;
                Console.WriteLine("Kökü alınacak sayıyı girin: ");
                sayi = Convert.ToDouble(Console.ReadLine());
                kok = Math.Sqrt(sayi);
                Console.WriteLine("sonuc: " + kok);
            }

            if (islem == 4)
            {
                int kenar, alan, cevre;
                Console.Write("Kenar değeri: ");
                kenar = Convert.ToInt32(Console.ReadLine());
                alan = kenar * kenar;
                cevre = kenar * 4;
                Console.WriteLine("Alan: " + alan);
                Console.WriteLine("Cevre: " + cevre);
            }

            if (islem == 5)
            {
                int kısakenar, uzunkenar, cevredik, alandik;
                Console.Write("Kısa kenar Girin: ");
                kısakenar = Convert.ToInt32(Console.ReadLine());
                Console.Write("Uzun kenar girin: ");
                uzunkenar= Convert.ToInt32(Console.ReadLine());

                cevredik = 2 * (kısakenar) + 2 * (uzunkenar);
                alandik = kısakenar * uzunkenar;
                Console.WriteLine("Alan:  " + alandik);
                Console.WriteLine("Cevre: " + cevredik);
            }

            if(islem==6)
            {
                int kenar, cevre;
                Console.Write("Kenar uzunluk girin: ");
                kenar= Convert.ToInt32(Console.ReadLine());
                cevre = kenar * 3;
                Console.WriteLine("Cevre: " + cevre);
            }
            Console.Read();
        }
    }
}
