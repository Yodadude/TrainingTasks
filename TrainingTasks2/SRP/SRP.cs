using System;
using System.Net.Mail;

namespace TrainingTasks2.SRP
{
    public class UserService
    {
        public void Register(string email, string password)
        {
			//if (!email.Contains("@"))
			//    throw new Exception("Email is not an email!");

        	var emailValidator = new EmailValidator();
			if (!emailValidator.IsValid(email))
				throw new Exception(emailValidator.Message);

			//var user = new User(email, password);
			//var db = new FakeDatabase();
			//db.Save(user);

        	var saveUser = new SaveUser();
			saveUser.Save(email, password);

			//var smtpClient = new FakeSmtpClient();
			//smtpClient.Send(new MailMessage("mysite@nowhere.com", email) { Subject = "Hello fool!" });

			var notifyUser = new NotifyUser();
			notifyUser.Send(email);
        }
    }
}
