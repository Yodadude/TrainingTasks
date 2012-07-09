using System;
using System.Text.RegularExpressions;

namespace TrainingTasks1
{
    public interface IPasswordValidation
    {
        PasswordValidationResult Validate(string password);
    }

	class PasswordValidation : IPasswordValidation
	{
		public PasswordValidationResult Validate(string password)
		{
			// Password must be specified
			if (String.IsNullOrWhiteSpace(password))
			{
				return new PasswordValidationResult { IsValid = false, Message = "Password must be specified." };
			}

			//	Password must not be less than 10 characters
			if (password.Trim().Length < 10)
			{
				return new PasswordValidationResult { IsValid = false, Message = "Password must be at least 10 characters in length." };
			}

			//	Password must contain 1 digit
			if (!Regex.IsMatch(password, "[0-9]+", RegexOptions.IgnoreCase))
			{
				return new PasswordValidationResult { IsValid = false, Message = "Password must be at least 1 number." };
			}

			//	Password must contain 1 upperchase character
			if (!Regex.IsMatch(password, "[A-Z]+"))
			{
				return new PasswordValidationResult { IsValid = false, Message = "Password must be at least 1 uppercase character." };
			}

			return new PasswordValidationResult { IsValid = true, Message = "" };
		}
	}
}
