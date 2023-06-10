using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models;

public partial class Agencija
{
    public int IdAg { get; set; }

    public string NazAg { get; set; } = null!;

    public string AdrAg { get; set; } = null!;

    public virtual ICollection<Nabavlja> Nabavljas { get; set; } = new List<Nabavlja>();

    public virtual ICollection<Nudi> Nudis { get; set; } = new List<Nudi>();

    public virtual ICollection<Rezervise> Rezervises { get; set; } = new List<Rezervise>();

    public virtual ICollection<Vodic> Vodics { get; set; } = new List<Vodic>();
}
