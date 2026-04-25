using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobDevFinalProject.Models
{
    public static class Global
    {
        public static List<Day> InfoList = new List<Day>()
        {
            new Day(){Time=new DateTime(2026, 1, 1), WOType="", Length=60, Calories=2000, Protein=90, Fat=80, Carbs=100, Water=20},
            new Day(){Time=new DateTime(2026, 1, 2), WOType="", Length=90, Calories=3000, Protein=90, Fat=80, Carbs=10, Water=30},
            new Day(){Time=new DateTime(2026, 1, 3), WOType="", Length=67, Calories=2500, Protein=90, Fat=60, Carbs=1000, Water=20},
            new Day(){Time=new DateTime(2026, 1, 4), WOType="", Length=67, Calories=1500, Protein=90, Fat=80, Carbs=100, Water=40}
        };
    }
}
