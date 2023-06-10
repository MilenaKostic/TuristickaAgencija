using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models;

public partial class Putovanje
{
    public int IdPuta { get; set; }

    public string NazPuta { get; set; } = null!;

    public int CenaPuta { get; set; }

    public DateTime DatumPol { get; set; }

    public DateTime DatumPov { get; set; }

    public virtual ICollection<Nudi> Nudis { get; set; } = new List<Nudi>();

    public virtual ICollection<Obuhvata> Obuhvata { get; set; } = new List<Obuhvata>();

    public virtual ICollection<Rezervise> Rezervises { get; set; } = new List<Rezervise>();
}
