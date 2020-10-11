using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Services;
using BLL.Request;
using DLL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL.RequestResponse;

namespace API.Controllers
{
    public class UpiCardEnrollmentController : ApiBaseController
    {
        private readonly ICardEnrollmentService _cardEnrollmentService;

        public UpiCardEnrollmentController(ICardEnrollmentService cardEnrollmentService)
        {
            _cardEnrollmentService = cardEnrollmentService;
        }

        [HttpPost]
        public async Task<IActionResult> CardEnrollment(CardEnrollmentRequestModel cardEnrollmentRequestModel)
        {
            return Ok(await _cardEnrollmentService.cardEnrollmentProcess(cardEnrollmentRequestModel));
        }
    }
}
