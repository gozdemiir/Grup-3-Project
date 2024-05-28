using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    class MedicationSchedule
    {
        public string Name { get; set; }
        public int DailyDoses { get; set; }
        public bool IsAfterMeal { get; set; }
        public string Condition { get; set; }
        public bool DissolveInWater { get; set; }

        public MedicationSchedule(string name, int dailyDoses, bool isAfterMeal, string condition, bool dissolveInWater = false)
        {
            Name = name;
            DailyDoses = dailyDoses;
            IsAfterMeal = isAfterMeal;
            Condition = condition;
            DissolveInWater = dissolveInWater;
        }

        public void TakeMedication()
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
