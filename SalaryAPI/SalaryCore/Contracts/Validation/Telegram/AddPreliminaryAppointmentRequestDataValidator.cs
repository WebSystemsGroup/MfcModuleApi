using FluentValidation;
using SalaryCore.Contracts.Telegram;
using SalaryCore.Extensions;

namespace SalaryCore.Contracts.Validation.Telegram
{
    public class AddPreliminaryAppointmentRequestDataValidator : AbstractValidator<AddPreliminaryAppointmentRequestData>
    {
        public AddPreliminaryAppointmentRequestDataValidator()
        {
            RuleFor(x => x.fio)
                .NotEmpty();
            RuleFor(x => x.phone)
                .MaxLength("Номер телефона", 15)
                .When(x => true);
            RuleFor(x => x.service)
                .GreaterThan(0)
                .LessThan(4);
            RuleFor(x => x.date)
                .NotEmpty();
            RuleFor(x => x.time)
                .NotEmpty();
        }
    }
}
