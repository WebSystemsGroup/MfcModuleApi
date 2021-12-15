using FluentValidation.Results;
using SalaryCore.Contracts.Validation.Telegram;
using System.Threading.Tasks;

namespace SalaryCore.Contracts.Telegram
{
    public record AddPreliminaryAppointmentRequestData
    {
        public string fio { get; set; }
        public string phone { get; set; }
        public int service { get; set; }
        public string date { get; set; }
        public string time { get; set; }

        public async Task<ValidationResult> ValidateAsync() =>
            await new AddPreliminaryAppointmentRequestDataValidator().ValidateAsync(this);
    }

    public record BasePreliminaryAppointment : AddPreliminaryAppointmentRequestData
    {
        public string source { get; init; } = "telegram";
        public string email { get; init; } = "telegram@test.ru";
    }

   
}
