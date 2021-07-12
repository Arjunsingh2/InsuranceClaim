using InsuranceClaim_Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaim_Microservice.Repository
{
    public class InitiateClaimrepo: IInitiateClaimRepo
    {
        private static InsurerDBContext _contexts;
        public InitiateClaimrepo(InsurerDBContext contexts)
        {
            _contexts = contexts;
            if (_contexts.InitiateClaims.Any())
            {
                return;
            }
            _contexts.InitiateClaims.AddRange
                (
            new InitiateClaim()
            {
                Cost = 25000,
                InsurerId = 1,
                TreatmentPlanId = 1,
                PatientName = "Michal",
                Ailment = "Low Back Pain",
                TreatmentPackageName = "Orthopedic",
                InsurerName = "Cognizant"

            }


         ) ;
            _contexts.SaveChanges();
        }

        public double GetBalance(InitiateClaim Claim)
        {

            var Insurer = _contexts.InsurerDetails.Where(p => p.InsurerId == Claim.InsurerId).FirstOrDefault();
            _contexts.InitiateClaims.Add(Claim);
            _contexts.SaveChanges();
            if (Claim.Cost <= Insurer.InsuranceAmountLimit)
                return 0;
            return Claim.Cost - Insurer.InsuranceAmountLimit;
        }
    }
}
