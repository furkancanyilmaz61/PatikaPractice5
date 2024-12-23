using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Kim Milyoner Olmak İster? Bilgi Yarışmasına Hoş Geldiniz!");
        Console.WriteLine("Amacınız, 3 sorudan en az 2 tanesini doğru cevaplamak ve büyük ödülü kazanmaktır!");

        int dogruSayisi = 0;

        // 1. Soru
        Console.WriteLine("\n1 → Kızınca tüküren hayvan hangisidir?");
        Console.WriteLine("A) Lama  B) Deve");
        string cevap1 = Console.ReadLine().ToUpper(); // Harf duyarlılığı kaldırıldı
        if (cevap1 == "A")
        {
            dogruSayisi++;
        }

        // 2. Soru
        Console.WriteLine("\n2 → Dünya'ya en yakın gezegen hangisidir?");
        Console.WriteLine("A) Venüs  B) Mars");
        string cevap2 = Console.ReadLine().ToUpper(); // Harf duyarlılığı kaldırıldı
        if (cevap2 == "B")
        {
            dogruSayisi++;
        }

        // İlk iki sorunun kontrolü
        if (dogruSayisi < 2)
        {
            // 3. Soruyu sorma ihtiyacı doğar
            Console.WriteLine("\n3 → 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
            Console.WriteLine("A) 7  B) 12");
            string cevap3 = Console.ReadLine().ToUpper(); // Harf duyarlılığı kaldırıldı
            if (cevap3 == "B")
            {
                dogruSayisi++;
            }
        }

        // Final Sonucu
        if (dogruSayisi >= 2)
        {
            Console.WriteLine("\nTebrikler! Büyük ödülü kazandınız!");
        }
        else
        {
            Console.WriteLine("\nÜzgünüz, büyük ödülü kazanamadınız. Tekrar deneyin!");
        }
    }
}
