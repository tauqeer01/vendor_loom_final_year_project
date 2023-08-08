using FinalYearProject.Utilities.EmailServices.IEmail;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.Threading.Tasks;

namespace FinalYearProject.Utilities.EmailServices
{
	public class EmailSender : IEmailSend
	{
		private readonly SmtpSettings _smtpSettings;

		public EmailSender(SmtpSettings smtpSettings)
		{
			_smtpSettings = smtpSettings;
		}

		public async Task SendEmailAsync(string recipientEmail, string subject, string body)
		{
			var message = new MimeMessage();
			message.From.Add(new MailboxAddress("Shop and Earn", _smtpSettings.SenderEmail));
			message.To.Add(new MailboxAddress("", recipientEmail));
			message.Subject = subject;

			var bodyBuilder = new BodyBuilder();
			bodyBuilder.HtmlBody = body; // Set the body as HTML

			message.Body = bodyBuilder.ToMessageBody();

			using (var client = new SmtpClient())
			{
				await client.ConnectAsync(_smtpSettings.Host, _smtpSettings.Port, SecureSocketOptions.Auto);
				await client.AuthenticateAsync(_smtpSettings.Username, _smtpSettings.Password);
				await client.SendAsync(message);
				await client.DisconnectAsync(true);
			}
		}
	}
}
