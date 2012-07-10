using System.Text.RegularExpressions;

namespace TrainingTasks1.Validators
{
	public class PasswordDigitValidator : IPasswordValidation
	{
		public PasswordValidationResult Validate(string password)
		{
			//	Password must contain 1 digit
			if (!Regex.IsMatch(password, "[0-9]+"))
			{
				return new PasswordValidationResult { IsValid = false, Message = "Password must be at least 1 number." };
			}

			return new PasswordValidationResult { IsValid = true, Message = "" };
		}
	}
}
