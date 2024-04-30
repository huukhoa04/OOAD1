using System;
using System.Collections.Generic;

namespace OOAD.Data;

public partial class Reminder
{
    public int AptId { get; set; }

    public DateTime RmdTime { get; set; }

    public virtual Appointment Apt { get; set; } = null!;
}
