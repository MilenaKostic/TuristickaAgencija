using System;
using System.Collections.Generic;

namespace TuristickaAgencija.Models;

public partial class Destinacija
{
    public int IdDest { get; set; }

    public string NazDest { get; set; } = null!;

    public virtual ICollection<Obuhvata> Obuhvata { get; set; } = new List<Obuhvata>();

    public virtual ICollection<SeDolazi> SeDolazis { get; set; } = new List<SeDolazi>();

    public virtual ICollection<Smestaj> Smestajs { get; set; } = new List<Smestaj>();
}
