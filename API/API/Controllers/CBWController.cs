using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Services;
using DLL.RequestResponseModel;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    //App Gateway
    public class CBW : ApiBaseController
    {
        private readonly ICBWService _cBWService;

        public CBW(ICBWService cBWService)
        {
            _cBWService = cBWService;
        }

        [HttpPost("AccountUpdateNotification")]
        public async Task<IActionResult> AccountUpdateNotification(UPIAccountUpdateNotificationRequestModel requestModel)
        {
            var result = await _cBWService.AccountUpdateNotification(requestModel);
            return Ok(result);
        }

        [HttpPost("CardStatusNotification")]
        public async Task<IActionResult> CardStatusNotification(UPICardStatusNotificationRequestModel requestModel)
        {
            var result = await _cBWService.CardStatusNotification(requestModel);
            return Ok(result);
        }

        [HttpPost("TransactionResultNotification")]
        public async Task<IActionResult> TransactionResultNotification(UPITransactionResultNotificationRequestModel requestModel)
        {
            var result = await _cBWService.TransactionResultNotification(requestModel);
            return Ok(result);
        }
        
        [HttpPost("AdditionalProcessing")]
        public async Task<IActionResult> AdditionalProcessing(UPIAuditionalProcessingRequestModel requestModel)
        {
            var result = await _cBWService.AdditionalProcessing(requestModel);
            return Ok(result);
        }
    }
}
