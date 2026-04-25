using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobDevFinalProject.Models
{
    public class Day
    {
        required public DateTime Time { get; set; }
        required public string WOType { get; set; }
        public int Length { get; set; }
        public int Calories { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }
        public int Carbs { get; set; }
        public int Water { get; set; }
    }
}
