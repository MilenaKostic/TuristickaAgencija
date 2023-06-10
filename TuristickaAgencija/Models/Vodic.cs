using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models;

public partial class Vodic
{
    public int IdVod { get; set; }

    public string JmbgVod { get; set; } = null!;

    public string ImeVod { get; set; } = null!;

    public string PrzVod { get; set; } = null!;

    public string BrVod { get; set; } = null!;

    public int? IdAg { get; set; }

    public virtual Agencija? IdAgNavigation { get; set; }
}
