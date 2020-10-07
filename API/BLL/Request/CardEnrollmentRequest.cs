using System;
using FluentValidation;

namespace BLL.RequestResponse
{
    public class CardEnrollmentRequestModel
    {
        public string deviceID { get; set; }
        public string cvminfo { get; set; }
        public string pin { get; set; }

    }

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
