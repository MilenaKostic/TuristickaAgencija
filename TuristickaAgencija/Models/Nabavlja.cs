using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models;

public partial class Nabavlja
{
    public int IdNabavlja { get; set; }

    public int IdAg { get; set; }

    public int IdPrzs { get; set; }

    public virtual Agencija IdAgNavigation { get; set; } = null!;

    public virtual PrevoznoSredstvo IdPrzsNavigation { get; set; } = null!;
}
