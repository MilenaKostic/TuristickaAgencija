using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models;

public partial class SeDolazi
{
    public int IdSeDolazi { get; set; }

    public int IdDest { get; set; }

    public int IdPrzs { get; set; }

    public virtual Destinacija IdDestNavigation { get; set; } = null!;

    public virtual PrevoznoSredstvo IdPrzsNavigation { get; set; } = null!;
}
