using InsuranceClaim_Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaim_Microservice.Repository
{
    public class InsurerRepo : IInusrerRepo
    {
        private static InsurerDBContext _context;
       
        public InsurerRepo(InsurerDBContext context)
        {
            _context = context;
            if (_context.InsurerDetails.Any())
            {
                return;
            }
            _context.InsurerDetails.AddRange(
                new InsurerDetail()
                {
                    //InsurerId = 1,
                    InsurerName = "Cognizant",
                    InsurerPackageName = "Aditya Birla Active Health Platinum",
                    InsuranceAmountLimit = 1561.0,
                    DisbursementDuration = "2 Year"
                },
            new InsurerDetail()
            {
                //InsurerId = 2,
                InsurerName = "Cognizant",
                InsurerPackageName = "Star Health Family Optima Plan",
                InsuranceAmountLimit = 1706.0,
                DisbursementDuration = "5 years"
            },
            new InsurerDetail()
            {
                //InsurerId = 3,
                InsurerName = "Cognizant",
                InsurerPackageName = "ICIC Lombard Complete Health Insurence Plane",
                InsuranceAmountLimit = 1697.0,
                DisbursementDuration = "1 years"
            },
             new InsurerDetail()
             {
                 //InsurerId = 4,
                 InsurerName = "Cognizant",
                 InsurerPackageName = "Care Health Plan",
                 InsuranceAmountLimit = 1661.0,
                 DisbursementDuration = "3 years"
             },
              new InsurerDetail()
              {
                  //InsurerId = 5,
                  InsurerName = "Cognizant",
                  InsurerPackageName = "Reliance Health infinity",
                  InsuranceAmountLimit = 1561.0,
                  DisbursementDuration = "3 years"
              },
               new InsurerDetail()
               {
                   //InsurerId = 6,
                   InsurerName = "Cognizant",
                   InsurerPackageName = "Care Health Plan",
                   InsuranceAmountLimit = 16613.0,
                   DisbursementDuration = "3 years"
               },
                new InsurerDetail()
                {
                    //InsurerId = 7,
                    InsurerName = "Cognizant",
                    InsurerPackageName = "Care Health Plan",
                    InsuranceAmountLimit = 1661.0,
                    DisbursementDuration = "3 years"
                },
                 new InsurerDetail()
                 {
                     //InsurerId = 8,
                     InsurerName = "Cognizant",
                     InsurerPackageName = "Care Health Plan",
                     InsuranceAmountLimit = 1661.0,
                     DisbursementDuration = "3 years"
                 },
                  new InsurerDetail()
                  {
                      //InsurerId = 9,
                      InsurerName = "Cognizant",
                      InsurerPackageName = "Care Health Plan",
                      InsuranceAmountLimit = 16613.0,
                      DisbursementDuration = "3 years"
                  },
                   new InsurerDetail()
                   {
                       //InsurerId = 10,
                       InsurerName = "Cognizant",
                       InsurerPackageName = "Care Health Plan",
                       InsuranceAmountLimit = 1661.0,
                       DisbursementDuration = "3 years"
                   }
         );

            _context.SaveChanges();

        }
        
        public IEnumerable<InsurerDetail> GetAllInsurerDetails()
{
            return _context.InsurerDetails.ToList();
        }

        public IEnumerable<InsurerDetail> GetInsurerByPackageName(int id)
        {
            return _context.InsurerDetails.Where(i => i.InsurerId == id).ToList();
        }
        
    }
}
