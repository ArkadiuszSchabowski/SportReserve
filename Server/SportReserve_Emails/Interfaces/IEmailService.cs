using SportReserve_Shared.Models.Email;
using SportReserve_Shared.Models.User;

namespace SportReserve_Emails.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailToAdmin(SendEmailToAdminDto dto);
        Task SendRegisterEmail(UserRegisteredEventDto userRegisteredEvent);
    }
}
