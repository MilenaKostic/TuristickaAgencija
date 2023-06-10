using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models;

public partial class Nudi
{
    public int IdNudi { get; set; }

    public int IdAg { get; set; }

    public int IdPuta { get; set; }

    public virtual Agencija IdAgNavigation { get; set; } = null!;

    public virtual Putovanje IdPutaNavigation { get; set; } = null!;
}
