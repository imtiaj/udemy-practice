using BLL.RequestResponseValidator;
using DLL.Models;
using DLL.RequestResponseModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface ICardEnrollmentService
    {
        Task<CardEnrollmentRequestModel> cardEnrollmentProcess(CardEnrollmentRequestModel cardEnrollmentModel);
    }

    public class CardEnrollmentService : ICardEnrollmentService
    {
        public async Task<CardEnrollmentRequestModel> cardEnrollmentProcess(CardEnrollmentRequestModel cardEnrollmentModel)
        {
            var isValidate = this.validateCardData(cardEnrollmentModel);
            var newItem = new CardEnrollmentRequestModel();
            if (isValidate)
            {
                return newItem;
            }
            return newItem;
        }

        public bool validateCardData(CardEnrollmentRequestModel employeeAddRequest)
        {
            return true;
        }
    }
}
