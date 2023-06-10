using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models;

public partial class Tipsmestaja
{
    public int IdTipa { get; set; }

    public string NazTipa { get; set; } = null!;

    public virtual ICollection<Smestaj> Smestajs { get; set; } = new List<Smestaj>();
}
