using InsuranceClaim_Microservice.Models;
using InsuranceClaim_Microservice.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace InsuranceClaim_Microservice.Controllers
{
    [Route("api/[controller]/[action]")]
    public class InsurerController : ControllerBase
    {
        private readonly IInusrerRepo _insurerRepository;
        private readonly IInitiateClaimRepo _repo;
        public InsurerController(IInusrerRepo insurerRepository,IInitiateClaimRepo repo)
        {
            _insurerRepository = insurerRepository;
            _repo = repo;
        }
        [HttpGet]
        [Authorize]
        public IActionResult GetAllInsurerDetails()
        {
            var a = _insurerRepository.GetAllInsurerDetails();
            return new OkObjectResult(a);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetInsurerByPackageName(int id)
        {
            var a = _insurerRepository.GetInsurerByPackageName(id);
            return new OkObjectResult(a);
        }
        [HttpPost]
        [Authorize]
        public IActionResult GetBalance([FromBody] InitiateClaim Claim)
        {
            var a = _repo.GetBalance(Claim);
            return new OkObjectResult(a);
        }
    } 
}
