using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingTasks2.SRP
{
	class EmailValidator
	{
		public string Message
		{
			get { return "Email is not an email!"; }
		}

		public bool IsValid (String email)
		{
			return email.Contains("@") ? true : false;
		}
	}
}
