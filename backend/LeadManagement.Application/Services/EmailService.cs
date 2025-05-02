using LeadManagement.Application.Interfaces;

namespace LeadManagement.Application.Services
{
    public class EmailService : IEmailService
    {
        public Task SendEmailAsync(string to, string subject, string body)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "email.log");
            var message = $"To: {to}\nSubjec: {subject}\nBody: {body}\n\n";
            return File.AppendAllTextAsync(path, message);
        }
    }
}
