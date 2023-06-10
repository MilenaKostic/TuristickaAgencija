using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models;

public partial class Rezervise
{
    public int IdK { get; set; }

    public int IdPuta { get; set; }

    public int IdPrzs { get; set; }

    public int IdAg { get; set; }

    public virtual Agencija IdAgNavigation { get; set; } = null!;

    public virtual Klijent IdKNavigation { get; set; } = null!;

    public virtual PrevoznoSredstvo IdPrzsNavigation { get; set; } = null!;

    public virtual Putovanje IdPutaNavigation { get; set; } = null!;
}
