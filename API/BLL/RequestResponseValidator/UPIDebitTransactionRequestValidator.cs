using System;
using DLL.RequestResponseModel;
using FluentValidation;

namespace BLL.RequestResponseValidator
{
    public class UPIDebitTransactionRequestValidator : AbstractValidator<UPIDebitTransactionRequest>
    {
        private readonly IServiceProvider _serviceProvider;
        public UPIDebitTransactionRequestValidator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            RuleFor(x => x.MsgInfo).NotNull();
            //RuleFor(x => x.cvminfo).NotNull();
            //RuleFor(x => x.pin).NotNull();

        }

    }

}
