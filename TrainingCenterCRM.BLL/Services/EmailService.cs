using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.BLL.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress(_configuration["MailSettings:Name"], _configuration["MailSettings:Mail"]));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            int port = int.Parse(_configuration["MailSettings:Port"]);

            using var client = new SmtpClient();
            await client.ConnectAsync(_configuration["MailSettings:Host"], port, true);
            await client.AuthenticateAsync(_configuration["MailSettings:Mail"], _configuration["MailSettings:Password"]);
            await client.SendAsync(emailMessage);

            await client.DisconnectAsync(true);
        }
        public string GenerateCourseInvitationMessage(Group group, Student student)
        {
            var mes = new StringBuilder();
            mes.AppendLine($"<h1>Dear, {student.Name} {student.Surname}!<h1>");
            mes.AppendLine($"<p>We inform you that your request for the course {group.Course.Title} has been approved.</p>");
            mes.AppendLine($"<p>The name of your group {group.Name}</p>");
            
            if (group.Teacher != null)
                mes.Append($"<p>Teacher is {group.Teacher.Name} {group.Teacher.Surname}</p>");
            mes.Append($"<p style='color:#e86363'>Your group starts with {group.StartDate:dd.MM.yyyy}.</p>");

            return mes.ToString();
        }
    }
}
