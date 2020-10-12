using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Services;
using DLL.RequestResponseModel;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    public class CBCard : ApiBaseController
    {
        private readonly ICBCardService _cbCardService;

        public CBCard(ICBCardService cbCardService)
        {
            _cbCardService = cbCardService;
        }

        [HttpPost("CreditTransaction")]
        public async Task<IActionResult> CreditTransaction(UPICreditTransactionRequest requestModel)
        {
            var result = await _cbCardService.CreditTransactionProcessAsync(requestModel);
            return Ok(result);
        }

        [HttpPost("DebitTransaction")]
        public async Task<IActionResult> DebitTransaction(UPIDebitTransactionRequest requestModel)
        {
            var result = await _cbCardService.DebitTransactionProcessAsync(requestModel);
            return Ok(result);
        }

    }
}
