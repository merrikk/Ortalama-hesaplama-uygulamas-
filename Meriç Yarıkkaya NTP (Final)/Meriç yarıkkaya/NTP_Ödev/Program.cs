using System;
namespace NTP_Ödev
{
    class Islem
    {
        public static void Hesapla()
        {

            int dersadet, notadet, sabit = 0, k = 1, sonuc = 0;
            Console.WriteLine("Ortalama Hesaplama uygulamasına hoşgeldiniz");
            Console.WriteLine("Not Geçer not 50 olarak alınmıştır!!");
            Console.WriteLine("kaç adet dersiniz var ?");
            dersadet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("her ders için kaç adet not giriceksiniz ?");
            notadet = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < dersadet; i++)
            {
                for (int j = 1; j < notadet + 1; j++)
                {
                    Console.WriteLine(k + ".ders için" + j + ". notunuzu giriniz");
                    sabit += Convert.ToInt32(Console.ReadLine());
                }
                k++;
            }
            sonuc = sabit / (dersadet * notadet);
            Console.WriteLine("girdiğiniz notların ortalaması:" + sonuc);
            if (sonuc < 50)
            {
                Console.WriteLine("malesef sınıfta kaldınız ve hiçbir belge alamazsınız!!");
            }
            else if (sonuc > 50 && sonuc < 70)
            {
                Console.WriteLine("Tebrikler sınıfı geçtiniz ama malesef ortalamanız 70 in altında olduğu için hiçbir belge alamazsınız!!");
            }
            else if (sonuc >= 70 && sonuc < 85)
            {
                Console.WriteLine("tebrikler sınıfı geçtiniz ortalamanız 85 in altında olduğu fakat 70 ten yüksek olduğu için teşekkür belgesi aldınız!! ");
            }
            else if (sonuc >= 85 || sonuc > 85)
            {
                Console.WriteLine("tebrikler sınıfı geçtiniz ortalamanız 85 veya üstünde olduğu için takdir belgesi aldınız!! ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Islem.Hesapla();
        }
    }
}
