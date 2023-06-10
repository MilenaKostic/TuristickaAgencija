using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models;

public partial class Autobus
{
    public int BrMesta { get; set; }

    public string RegBrBus { get; set; } = null!;

    public int IdPrzs { get; set; }

    public virtual PrevoznoSredstvo IdPrzsNavigation { get; set; } = null!;
}
