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

        Console.WriteLine("Bir haftalık ilaç programı başlıyor...");

        for (int day = 1; day <= 7; day++)
        {
            Console.WriteLine($"Gün {day}:");
            foreach (var med in medications)
            {
                med.IlacAlmak();
            }
            Console.WriteLine(); // Gün sonu için bir satır boşluk
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
