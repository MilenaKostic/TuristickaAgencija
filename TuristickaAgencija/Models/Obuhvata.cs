using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models;

public partial class Obuhvata
{
    public int IdObuhvata { get; set; }

    public int IdPuta { get; set; }

    public int IdDest { get; set; }

    public virtual Destinacija IdDestNavigation { get; set; } = null!;

    public virtual Putovanje IdPutaNavigation { get; set; } = null!;
}
