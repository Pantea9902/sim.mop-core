using System;
using System.Collections.Generic;

namespace sim.mop.Models;

public partial class VwDataTable
{
    public string? fldMGCode { get; set; }

    public string? fldMESC { get; set; }

    public string? fldUnit { get; set; }

    public string? fldType { get; set; }

    public bool? fldRahbordi { get; set; }

    public bool? fldPorMasraf { get; set; }

    public decimal?fldValue { get; set; }

    public bool? fldInternalConstruct { get; set; }

    public int? fldDepth { get; set; }

    public string? fldName { get; set; }

    public string? fldUserName { get; set; }

    public string? Expr1 { get; set; }

    public int? fldID { get; set; }

    public string? fldConstructorID { get; set; }

    public string? fldConstructorName { get; set; }

    public string? fldConstructPlanYear { get; set; }

    public string? fldDescHeader { get; set; }

    public int? fldNeedOfYear { get; set; }

    public bool? fldHasCert { get; set; }

    public string? fldCertPlanYear { get; set; }

    public string? fldMesccenter { get; set; }

    public int? Expr2 { get; set; }

    public string? fldRegUser { get; set; }

    public string? fldRegisterDate { get; set; }

    public string? fldCertRefrence { get; set; }

	internal static void Add(VwDataTable vwDataTable)
	{
		throw new NotImplementedException();
	}
}
