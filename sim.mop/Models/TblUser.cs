using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sim.mop.Models {
   
    public partial class TblUser
    {
        public int fldId { get; set; }

        public string? fldMGCode { get; set; }

        public string? fldName { get; set; }

		public string fldUserName { get; set; } = null!;
        
        public string? fldPassword { get; set; }

        public bool fldIsActive { get; set; }

        public string? fldPermission { get; set; }
    }
}
