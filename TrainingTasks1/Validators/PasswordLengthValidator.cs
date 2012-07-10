using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingTasks1.Validators
{
	public class PasswordLengthValidator : IPasswordValidation
	{
		public PasswordValidationResult Validate(string password)
		{
			//	Password must not be less than 10 characters
			if (password.Trim().Length < 10)
			{
				return new PasswordValidationResult { IsValid = false, Message = "Password must be at least 10 characters in length." };
			}

			return new PasswordValidationResult { IsValid = true, Message = "" };
		}
	}
}
