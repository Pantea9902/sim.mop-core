using System;
using System.Collections.Generic;

namespace sim.mop.Models;

public partial class VwIntenalConstructionIndex
{
    public string? FldMgcode { get; set; }

    public int? ItemCount { get; set; }

    public int? InternalConstructItemCount { get; set; }

    public double? InternalConstCountIndex { get; set; }

    public int? TargetConstCount { get; set; }

    public decimal? ItemsValue { get; set; }

    public decimal? InternalConstructItemsValue { get; set; }

    public double? InternalConstValueIndex { get; set; }

    public decimal? TargetConstValue { get; set; }
}
