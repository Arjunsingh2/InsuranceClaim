using InsuranceClaim_Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaim_Microservice.Repository
{
     public interface IInusrerRepo
    {
        public IEnumerable<InsurerDetail> GetAllInsurerDetails();
        public IEnumerable<InsurerDetail> GetInsurerByPackageName(int id);
       
    }
}
