using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsuranceClaim.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceClaim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceClaimController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(InsuranceClaimController));
        public static List<InsurerDetail> insurerDetails = new List<InsurerDetail>()
        {
            new InsurerDetail()
            {
                InsurerName = "Bharti Axa",
                InsurerPackageName = "Silver",
                InsuranceAmountLimit = 1000,
                DisbursementDuration = "2 weeks"
            },
            new InsurerDetail()
            {
                InsurerName = "Kodak",
                InsurerPackageName = "Gold",
                InsuranceAmountLimit = 1500,
                DisbursementDuration = "2 weeks"
            }

        };
        // GET: api/InsuranceClaim
        [HttpGet]
        public List<InsurerDetail> Get()
        {
            _log4net.Info("Get Method Called");
            return insurerDetails;
        }

        // GET: api/InsuranceClaim/5
        [HttpGet("{id}", Name = "Get")]
        public InsurerDetail Get(string id)
        {
            _log4net.Info("Get by ID method called");
            InsurerDetail insurer = insurerDetails.Where(x => x.InsurerPackageName == id).FirstOrDefault();
            return insurer;
        }

        // POST: api/InsuranceClaim
        [HttpPost]
        public double Post(InitiateClaim initiateClaim)
        {
            _log4net.Info("Initiate Claim method called. Balance to be returned in this method");
            double balance = initiateClaim.Cost - initiateClaim.InsuranceAmountLimit;
            if (balance < 0)
                return 0;
            else
                return balance;

        }

     
    }
}
