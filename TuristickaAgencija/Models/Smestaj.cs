using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models;

public partial class Smestaj
{
    public int IdDest { get; set; }

    public int IdSm { get; set; }

    public string NazSm { get; set; } = null!;

    public int IdTipa { get; set; }

    public virtual Destinacija IdDestNavigation { get; set; } = null!;

    public virtual Tipsmestaja IdTipaNavigation { get; set; } = null!;
}
