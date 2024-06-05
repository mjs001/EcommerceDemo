namespace ecommerceWithAngular.Services.Infrastructure
{
    public interface IEmailSender
    {


        Task SendEmailAsync(string email, string subject, string msg);
        
    }
}
