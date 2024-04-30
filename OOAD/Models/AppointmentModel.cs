using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD.Models
{
    public class AppointmentModel
    {
        public int Userid { get; set; }
        public string AptName { get; set; } = null!;

        public string AptLocation { get; set; } = null!;

        public DateTime? AptStartTime { get; set; }

        public DateTime? AptEndTime { get; set; }
    }
}
