using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarPanels.Models.Entites
{
    public class Panel
    {
        public long Id { get; set; }
        public string Panel_ID { get; set; }
        public string Current_Mode { get; set; }
    }
}
