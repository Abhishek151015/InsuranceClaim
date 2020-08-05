using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaim.Models
{
    public class InitiateClaim
    {
        public string PatientName { get; set; }
        public string Ailment { get; set; }
        public string TreatmentPackageName { get; set; }
        public string InsurerName { get; set; }

        public double Cost { get; set; }
        public double InsuranceAmountLimit { get; set; }
    }
}
