using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaim_Microservice.Models
{
    public class InitiateClaim
    {
        public InitiateClaim()
        { }
        public int Id { get; set; }
        public string InsurerName { get; set; }
        public int InsurerId { get; set; }
        public string PatientName { get; set; }
        public string Ailment { get; set; }
        public int TreatmentPlanId { get; set; }
        public string TreatmentPackageName { get; set; } 
        public double Cost { get; set; }
      
    }
}
