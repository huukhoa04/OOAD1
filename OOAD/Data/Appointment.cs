using System;
using System.Collections.Generic;

namespace OOAD.Data;

public partial class Appointment
{
    public int Userid { get; set; }

    public int AptId { get; set; }

    public string AptName { get; set; } = null!;

    public string AptLocation { get; set; } = null!;

    public DateTime? AptStartTime { get; set; }

    public DateTime? AptEndTime { get; set; }

    public virtual ICollection<Reminder> Reminders { get; set; } = new List<Reminder>();

    public virtual User User { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
