
namespace Service.Email
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email);
    }
}
