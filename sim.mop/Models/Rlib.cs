using System;
using System.Collections.Generic;

namespace sim.mop.Models;

public partial class Rlib
{
    public int FldId { get; set; }

    public string? FldMesc { get; set; }

    public string? FldMesccenter { get; set; }

    public string? FldUnit { get; set; }

    public string? FldDesc { get; set; }

    public string? FldStandardCode { get; set; }

    public bool FldMeschasInventory { get; set; }

    public string? FldMescfull { get; set; }

    public string? FldDescHeader { get; set; }

    public string? FldDescSubHeader { get; set; }

    public string? FldDescItem { get; set; }

    public string? FldIndecator { get; set; }

    public string? FldMainGroup { get; set; }

    public string? FldPartNo { get; set; }
}
