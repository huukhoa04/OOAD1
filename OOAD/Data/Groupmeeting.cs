using System;
using System.Collections.Generic;

namespace OOAD.Data;

public partial class Groupmeeting
{
    public int AptId { get; set; }

    public int Userid { get; set; }

    public virtual Appointment Apt { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
