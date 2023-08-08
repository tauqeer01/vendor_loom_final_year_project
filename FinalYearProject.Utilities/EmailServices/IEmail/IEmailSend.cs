using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.Utilities.EmailServices.IEmail
{
	public interface IEmailSend
	{
		Task SendEmailAsync(string recipientEmail, string subject, string body);
	}
}
