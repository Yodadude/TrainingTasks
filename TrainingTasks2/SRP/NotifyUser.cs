using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace TrainingTasks2.SRP
{
	public class NotifyUser
	{
		public void Send(string email)
		{
			var smtpClient = new FakeSmtpClient();
			smtpClient.Send(new MailMessage("mysite@nowhere.com", email) { Subject = "Hello fool!" });
		}
	}
}
