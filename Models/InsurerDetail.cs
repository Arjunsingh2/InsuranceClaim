using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaim_Microservice.Models
{
    public class InsurerDetail
    {
        [Key]
        public int InsurerId { get; set; }
        public string InsurerName { get; set; }
        public string InsurerPackageName { get; set; }
        public double InsuranceAmountLimit { get; set; }
        public string DisbursementDuration { get; set; }
        
    }
}
