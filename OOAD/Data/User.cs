using System;
using System.Collections.Generic;

namespace OOAD.Data;

public partial class User
{
    public int Userid { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? UsernameLog { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<Appointment> Apts { get; set; } = new List<Appointment>();
}
