using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceBox.Models
{
    public class MeasurementUnit
    {
        public int MeasurementUnitId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Type { get; set; }
    }
}
