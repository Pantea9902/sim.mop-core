using System;
using System.Collections.Generic;

namespace sim.mop.Models;

public partial class TblMginfo
{
    public int FldId { get; set; }

    public string? FldMgCode { get; set; }

    public string? FldMgName { get; set; }

    public int? FldParentId { get; set; }
}
