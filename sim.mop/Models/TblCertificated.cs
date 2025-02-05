using System;
using System.Collections.Generic;

namespace sim.mop.Models;

public partial class TblCertificated
{
    public int FldId { get; set; }

    public string? FldMgcode { get; set; }

    public string? FldMesc { get; set; }

    public string? FldUnit { get; set; }

    public string? FldMesccenter { get; set; }

    public bool? FldHasCert { get; set; }

    public string? FldCertRefrence { get; set; }

    public string? FldCertPlanYear { get; set; }

    public string? FldDescHeader { get; set; }

    public string? FldRegisterDate { get; set; }

    public string? FldRegUser { get; set; }
}
