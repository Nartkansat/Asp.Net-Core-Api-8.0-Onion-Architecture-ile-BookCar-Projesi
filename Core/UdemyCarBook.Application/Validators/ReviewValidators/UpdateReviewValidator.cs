using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commands.ReviewCommands;

namespace UdemyCarBook.Application.Validators.ReviewValidators
{
    public class UpdateReviewValidator:AbstractValidator<UpdateReviewCommand>
    {
        public UpdateReviewValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Lütfen müşteri adını boş geçmeyiniz");
            RuleFor(x => x.CustomerName).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz");

            RuleFor(x => x.RaitingValue).NotEmpty().WithMessage("Lütfen değerlendirme yapınız");

            RuleFor(x => x.Comment).NotEmpty().WithMessage("Lütfen yorum yapınız");
            RuleFor(x => x.Comment).MinimumLength(20).WithMessage("Lütfen en az 20 karakter giriniz");
            RuleFor(x => x.Comment).MaximumLength(500).WithMessage("Lütfen en çok 500 karakter giriniz");
        }
    }
}
