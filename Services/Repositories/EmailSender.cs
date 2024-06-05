using ecommerceWithAngular.Services.Infrastructure;

namespace ecommerceWithAngular.Services.Repositories
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string msg)
        {
            return Task.CompletedTask;
        }
    }
}
