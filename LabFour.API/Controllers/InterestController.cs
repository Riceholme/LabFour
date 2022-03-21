using LabFour.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFour.API.Controllers
{
    public class InterestController : ControllerBase
    {
        private IInterestRepository _interestRepo;

        public InterestController(IInterestRepository interestRepo)
        {
            _interestRepo = interestRepo;
        }
    }
}
