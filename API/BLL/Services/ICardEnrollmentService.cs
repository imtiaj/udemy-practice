using DLL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface ICardEnrollmentService
    {
        Task<CardEnrollmentModel> cardEnrollmentProcess(CardEnrollmentModel cardEnrollmentModel);
    }

    public class CardEnrollmentService : ICardEnrollmentService
    {
        public async Task<CardEnrollmentModel> cardEnrollmentProcess(CardEnrollmentModel cardEnrollmentModel)
        {
            var isValidate = this.validateCardData(cardEnrollmentModel);
            var newItem = new CardEnrollmentModel();
            if (isValidate)
            {
                return newItem;
            }
            return newItem;
        }

        public bool validateCardData(CardEnrollmentModel employeeAddRequest)
        {
            return true;
        }
    }
}
