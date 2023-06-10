using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models;

public partial class PrevoznoSredstvo
{
    public int IdPrzs { get; set; }

    public string KategorijaPrzs { get; set; } = null!;

    public virtual Autobus? Autobu { get; set; }

    public virtual Automobil? Automobil { get; set; }

    public virtual ICollection<Nabavlja> Nabavljas { get; set; } = new List<Nabavlja>();

    public virtual ICollection<Rezervise> Rezervises { get; set; } = new List<Rezervise>();

    public virtual ICollection<SeDolazi> SeDolazis { get; set; } = new List<SeDolazi>();
}
