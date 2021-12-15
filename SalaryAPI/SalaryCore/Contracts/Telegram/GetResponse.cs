using System;
using System.Collections.Generic;

namespace SalaryCore.Contracts.Telegram
{
    public record GetTelegramMfcResponseData(Guid MfcId, int QueueId, string OfficeNameSmall, string MfcAddress, 
        string Website, string PhoneNumber, string MfcEmail);

    public record GetDatePreliminaryAppointmentResponseData(string Date_number, List<string> Time);

    public record AddPreliminaryAppointmentResponseData(string Code);
}
