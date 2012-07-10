using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingTasks1.Validators
{
	public class PasswordEmptyValidator : IPasswordValidation
	{
		public PasswordValidationResult Validate(string password)
		{
			// Password must be specified
			if (String.IsNullOrWhiteSpace(password))
			{
				return new PasswordValidationResult { IsValid = false, Message = "Password must be specified." };
			}

			return new PasswordValidationResult { IsValid = true, Message = "" };
		}
	}
}
