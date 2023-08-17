using Microsoft.AspNetCore.Identity.UI.Services;

namespace WebUygulamaProje1.Ultility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
          return Task.CompletedTask;
        }
    }
}
