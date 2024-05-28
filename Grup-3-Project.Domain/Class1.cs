namespace Grup_3_Project.Domain
{
    public class Class1
    {
        {
        static void Main(string[] args)
        {
            
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
