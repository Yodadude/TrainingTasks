using TrainingTasks1.Validators;

namespace TrainingTasks1
{
	public class PasswordValidationService : IPasswordValidation
	{
		public IPasswordValidation[] Validators
		{
			get
			{
				return new IPasswordValidation[]
				       	{
				       		new PasswordEmptyValidator(),
				       		new PasswordLengthValidator(),
				       		new PasswordDigitValidator(),
				       		new PasswordUppercaseValidator()
				       	};
			}
		}

		public PasswordValidationResult Validate(string password)
		{
			var result = new PasswordValidationResult { IsValid = true, Message = "" };

			foreach (var validator in Validators)
			{
				result = validator.Validate(password);
				if (!result.IsValid)
					break;
			}
			return result;
		}
	}
}
