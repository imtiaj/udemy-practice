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

        [HttpPost("AccountBalanceInquiry")]
        public async Task<IActionResult> AccountBalanceInquiry(UPIAccountBalanceInquiryRequest requestModel)
        {
            var result = await _cbCardService.AccountBalanceInquiryProcessAsync(requestModel);
            return Ok(result);
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

        [HttpPost("GetCashOutToken")]
        public async Task<IActionResult> GetCashOutToken(UPICashOutTokenRequest requestModel)
        {
            var result = await _cbCardService.GetCashOutTokenProcessAsync(requestModel);
            return Ok(result);
        }

        [HttpPost("KycVerification")]
        public async Task<IActionResult> KycVerification(UPIKycVerificationRequest requestModel)
        {
            var result = await _cbCardService.KycVerificationProcessAsync(requestModel);
            return Ok(result);
        }

        [HttpPost("MerchantVerification")]
        public async Task<IActionResult> MerchantVerification(UPIMerchantVerificationRequest requestModel)
        {
            var result = await _cbCardService.MerchantVerificationProcessAsync(requestModel);
            return Ok(result);
        }

        [HttpPost("OpenAccount")]
        public async Task<IActionResult> OpenAccount(UPIOpenAccountRequestModel requestModel)
        {
            var result = await _cbCardService.OpenAccount(requestModel);
            return Ok(result);
        }
        
        [HttpPost("P2PTransfer")]
        public async Task<IActionResult> P2PTransfer(UPIP2PRequestModel requestModel)
        {
            var result = await _cbCardService.P2PTransfer(requestModel);
            return Ok(result);
        }

        [HttpPost("ReversalTransaction")]
        public async Task<IActionResult> ReversalTransaction(UPIReversalTransactionRequestModel requestModel)
        {
            var result = await _cbCardService.ReversalTransaction(requestModel);
            return Ok(result);
        }
        
        [HttpPost("TransactionInquiry")]
        public async Task<IActionResult> TransactionInquiry(UPITransactionInquiryRequestModel requestModel)
        {
            var result = await _cbCardService.TransactionInquiry(requestModel);
            return Ok(result);
        }

    }
}
