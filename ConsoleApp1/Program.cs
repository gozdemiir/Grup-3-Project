using System;
using System.Collections.Generic;
using Grup_3_Project.Domain;

class Program
{
    static void Main(string[] args)
    {
        List<IlacProgrami> medications = new List<IlacProgrami>
        {
            new IlacProgrami("A", 2, true, "tok"),
            new IlacProgrami("B", 3, true, "tok"),
            new IlacProgrami("C", 3, true, "tok"),
            new IlacProgrami("D", 1, false, "tok", true),
            new IlacProgrami("E", 3, false, "aç")
        };

        Console.WriteLine("İlaç programı başlıyor...");

        while (true)
        {
            Console.Write("Hangi günün ilaçlarını görmek istiyorsunuz (1-7)? Çıkmak için 0 girin: ");
            if (int.TryParse(Console.ReadLine(), out int day) && day >= 0 && day <= 7)
            {
                if (day == 0)
                {
                    break;
                }

                Console.WriteLine($"Gün {day}:");
                foreach (var med in medications)
                {
                    med.IlacAlmak();
                }
                Console.WriteLine(); // Gün sonu için bir satır boşluk
            }
            else
            {
                Console.WriteLine("Geçersiz giriş, lütfen 1 ile 7 arasında bir sayı girin.");
            }
        }

        Console.Write("Bu hafta sonunda ilaçlara devam etmek istiyor musunuz? (Evet/Hayır): ");
        string response = Console.ReadLine().ToUpper();

        if (response == "EVET")
        {
            Console.WriteLine("İlaçlara devam ediyorsunuz.");
        }
        else
        {
            Console.WriteLine("İlaçları bırakıyorsunuz. Geçmiş olsun.");
        }
    }
}
