using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models;

public partial class Klijent
{
    public int IdK { get; set; }

    public string JmbgK { get; set; } = null!;

    public string ImeK { get; set; } = null!;

    public string PrzK { get; set; } = null!;

    public string BrK { get; set; } = null!;

    public virtual ICollection<Rezervise> Rezervises { get; set; } = new List<Rezervise>();
}
