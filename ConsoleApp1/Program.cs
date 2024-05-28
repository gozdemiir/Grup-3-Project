
using ConsoleApp1;

List<MedicationSchedule> medications = new List<MedicationSchedule>
            {
                new MedicationSchedule("A", 2, true, "tok"),
                new MedicationSchedule("B", 3, true, "tok"),
                new MedicationSchedule("C", 3, true, "tok"),
                new MedicationSchedule("D", 1, false, "tok", true),
                new MedicationSchedule("E", 3, false, "aç")
            };

            Console.WriteLine("Bir haftalık ilaç programı başlıyor...");

            for (int day = 1; day <= 7; day++)
            {
                Console.WriteLine($"Gün {day}:");
                foreach (var med in medications)
                {
                    med.TakeMedication();
                }
            }

            Console.Write("Bir hafta sonunda ilaçlara devam etmek istiyor musunuz? (E/H): ");
            string response = Console.ReadLine().ToUpper();

            if (response == "E")
            {
                Console.WriteLine("İlaçlara devam ediyorsunuz.");
            }
            else
            {
                Console.WriteLine("İlaçları bırakıyorsunuz.");
            }
    