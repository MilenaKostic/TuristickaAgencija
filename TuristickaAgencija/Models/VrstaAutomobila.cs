using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models;

public partial class vrstaAutomobila
{
    public int IdVrste { get; set; }

    public string NazVrste { get; set; } = null!;

    public virtual ICollection<Automobil> Automobils { get; set; } = new List<Automobil>();
}
