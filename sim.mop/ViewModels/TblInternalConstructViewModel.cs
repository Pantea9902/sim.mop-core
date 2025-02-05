
using System;
using System.Collections.Generic;


namespace sim.mop.ViewModels
{
	public class TblInternalConstructViewModel
	{
		public int FldId { get; set; }

		public string? FldMgcode { get; set; }

		public string? FldMesc { get; set; }

		public string? FldUnit { get; set; }

		public string? FldMesccenter { get; set; }

		public string? FldType { get; set; }

		public bool FldRahbordi { get; set; }

		public bool FldPorMasraf { get; set; }

		public decimal? FldValue { get; set; }

		public bool FldInternalConstruct { get; set; }

		public int? FldDepth { get; set; }

		public string? FldConstructorName { get; set; }

		public string? FldConstructorId { get; set; }

		public string? FldConstructPlanYear { get; set; }

		public string? FldDescHeader { get; set; }

		public int? FldNeedOfYear { get; set; }

		public bool FldHasCert { get; set; }

		public string? FldCertRefrence { get; set; }

		public string? FldCertPlanYear { get; set; }

		public string? FldRegisterDate { get; set; }

		public string? FldRegUser { get; set; }
	}
}
