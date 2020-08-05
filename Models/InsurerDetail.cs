using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace InsuranceClaim.Models
{
    public class InsurerDetail
    {
        [Key]
        public string InsurerName { get; set; }
        public string InsurerPackageName { get; set; }
        public int InsuranceAmountLimit { get; set; }
        public string DisbursementDuration { get; set; }
    }
}
