using System;
using DLL.RequestResponseModel;
using FluentValidation;

namespace BLL.RequestResponseValidator
{
    public class CardEnrollmentRequestModelValidator : AbstractValidator<CardEnrollmentRequestModel>
    {
        private readonly IServiceProvider _serviceProvider;
        public CardEnrollmentRequestModelValidator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            RuleFor(x => x.deviceID).NotNull();
            RuleFor(x => x.cvminfo).NotNull();
            RuleFor(x => x.pin).NotNull();

        }

        //private async Task<bool> TransactionTypeActive(string transactionType, CancellationToken token)
        //{
        //    var unitOfWork = _serviceProvider.GetRequiredService<IUnitOfWork>();
        //    return await unitOfWork.TransactionTypeRepository.GetTransactionTypeStatus(ProjectHelper.TransactionType.BlockbusterMovieTicket.ToString());
        //}
    }

}
