 using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. AŞAMA: 10 adet tam sayı verisi alacak bir dizi tanımlama
        Console.WriteLine("=== AŞAMA 1: DİZİ TANIMLAMA ===");
        int[] sayilar = new int[10]; // 10 elemanlı int dizisi
        Console.WriteLine("10 elemanlı dizi tanımlandı.\n");

        // 2. AŞAMA: For döngüsü ile doldurma ve foreach ile yazdırma
        Console.WriteLine("=== AŞAMA 2: DİZİYİ DOLDURMA VE YAZDIRMA ===");
        
        // For döngüsü ile diziye değer atama
        Console.WriteLine("Dizi for döngüsü ile dolduruluyor...");
        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = (i + 1) * 5; // Örnek değerler: 5, 10, 15, 20, ...
            Console.WriteLine($"sayilar[{i}] = {sayilar[i]}");
        }

        Console.WriteLine("\nDizi foreach döngüsü ile yazdırılıyor:");
        foreach (int sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine("\n");

        // 3. AŞAMA: Kullanıcıdan yeni değer alıp diziye ekleme
        Console.WriteLine("=== AŞAMA 3: YENİ ELEMAN EKLEME ===");
        Console.Write("11. eleman olarak eklemek istediğiniz sayıyı girin: ");
        int yeniSayi = Convert.ToInt32(Console.ReadLine());

        // Yeni bir dizi oluşturup eski verileri kopyalama
        int[] yeniDizi = new int[11]; // 11 elemanlı yeni dizi
        
        // Eski dizinin elemanlarını yeni diziye kopyalama
        for (int i = 0; i < sayilar.Length; i++)
        {
            yeniDizi[i] = sayilar[i];
        }
        
        // 11. elemanı ekleme
        yeniDizi[10] = yeniSayi;
        
        Console.WriteLine("\nYeni eleman eklendi. Güncel dizi:");
        foreach (int sayi in yeniDizi)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine("\n");

        // 4. AŞAMA: Diziyi büyükten küçüğe sıralama
        Console.WriteLine("=== AŞAMA 4: BÜYÜKTEN KÜÇÜĞE SIRALAMA ===");
        
        // Array.Sort ile küçükten büyüğe sıralama
        Array.Sort(yeniDizi);
        
        // Array.Reverse ile büyükten küçüğe çevirme
        Array.Reverse(yeniDizi);
        
        Console.WriteLine("Dizi büyükten küçüğe sıralandı:");
        foreach (int sayi in yeniDizi)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();

        // BONUS: LINQ kullanarak alternatif sıralama yöntemi
        Console.WriteLine("\n=== BONUS: LINQ İLE SIRALAMA ===");
        var siraliDizi = yeniDizi.OrderByDescending(x => x).ToArray();
        
        Console.WriteLine("LINQ ile büyükten küçüğe:");
        foreach (int sayi in siraliDizi)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();

        Console.WriteLine("\nProgram tamamlandı. Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}