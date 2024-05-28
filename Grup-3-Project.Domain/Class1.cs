namespace Grup_3_Project.Domain
{
    public class Class1
    {
        {
        static void Main(string[] args)
        {
            List<ilacProgramı> medications = new List<ilacProgramı>
            {
                new ilacProgramı("A", 2, true, "tok"),
                new ilacProgramı("B", 3, true, "tok"),
                new ilacProgramı("C", 3, true, "tok"),
                new ilacProgramı("D", 1, false, "tok", true),
                new ilacProgramı("E", 3, false, "aç")
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

            Console.Write("Bu hafta sonunda ilaçlara devam etmek istiyor musunuz? (Evet/Hayır): ");
            string response = Console.ReadLine().ToUpper();

            if (response == "Evet")
            {
                Console.WriteLine("İlaçlara devam ediyorsunuz.");
            }
            else
            {
                Console.WriteLine("İlaçları bırakıyorsunuz.Geçmiş olsun");
            }
        }
    }

    class ilacProgramı
    {
        public string Name { get; set; }
        public int DailyDoses { get; set; }
        public bool IsAfterMeal { get; set; }
        public string Condition { get; set; }
        public bool DissolveInWater { get; set; }

        public ilacProgramı(string name, int dailyDoses, bool isAfterMeal, string condition, bool dissolveInWater = false)
        {
            Name = name;
            DailyDoses = dailyDoses;
            IsAfterMeal = isAfterMeal;
            Condition = condition;
            DissolveInWater = dissolveInWater;
        }

        public void ilacAlmak()
        {
            for (int dose = 1; dose <= DailyDoses; dose++)
            {
                string message = $"İlaç {Name} doz {dose}: ";
                if (DissolveInWater)
                {
                    message += "suda eritilerek ";
                }

                message += Condition == "aç" ? "aç karnına " : "tok karnına ";
                message += "alınacak.";
                
                Console.WriteLine(message);
            }
        }
    }
 }
    
}
