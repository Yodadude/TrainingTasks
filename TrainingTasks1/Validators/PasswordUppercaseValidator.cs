using System.Text.RegularExpressions;

namespace TrainingTasks1
{
	public class PasswordUppercaseValidator : IPasswordValidation
	{
		public PasswordValidationResult Validate(string password)
		{
			//	Password must contain 1 upperchase character
			if (!Regex.IsMatch(password, "[A-Z]+"))
			{
				return new PasswordValidationResult { IsValid = false, Message = "Password must be at least 1 uppercase character." };
			}

			return new PasswordValidationResult { IsValid = true, Message = "" };
		}

	}
}
