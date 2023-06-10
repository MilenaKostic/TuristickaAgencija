using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models;

public partial class Automobil
{
    public string RegBrAuto { get; set; } = null!;

    public int IdVrste { get; set; }

    public int IdPrzs { get; set; }

    public virtual PrevoznoSredstvo IdPrzsNavigation { get; set; } = null!;

    public virtual vrstaAutomobila IdVrsteNavigation { get; set; } = null!;
}
