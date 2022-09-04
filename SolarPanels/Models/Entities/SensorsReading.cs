using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarPanels.Models.Entites
{
    public class SensorsReading
    {
        public long Id { get; set; }
        public string SensorID { get; set; }
        public Nullable<decimal> current { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public string FormattedDate => AddedDate.ToString();
        public string Panel_ID { get; set; }
        public Nullable<decimal> Altitude { get; set; }
        public Nullable<decimal> Azimuth { get; set; }
    }
}
