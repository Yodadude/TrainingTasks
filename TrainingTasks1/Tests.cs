using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TrainingTasks1
{
    [TestFixture]
    public class PasswordValidatorTests
    {
        // 1. Should implement 3 rules (must have a number, must have an uppercase letter, must be min of 10 in length). More may be needed later.
        // 2. A Blank password is not valid (First test stub below)
        // 3. If a password is invalid the reason it is invalid should be in the ValidationResult 
        //
        // Notes: Tests should cover all functionality
        //        C# conventions should be followed

        [Test]
        public void A_Blank_Password_Is_Not_Valid()
        {
			IPasswordValidation validation = new PasswordValidation();
            var result = validation.Validate("");

            Assert.False(result.IsValid);
            Assert.AreEqual(result.Message, "Password must be specified.");
        }

		[Test]
		public void Password_Must_Be_Correct_Length()
		{
			IPasswordValidation validation = new PasswordValidation();
			var result = validation.Validate("x");

			Assert.False(result.IsValid);
			Assert.AreEqual(result.Message, "Password must be at least 10 characters in length.");
		}

		[Test]
		public void Password_Must_Contain_Digit()
		{
			IPasswordValidation validation = new PasswordValidation();
			var result = validation.Validate("xxxxxxxxxx");

			Assert.False(result.IsValid);
			Assert.AreEqual(result.Message, "Password must be at least 1 number.");
		}

		[Test]
		public void Password_Must_Contain_Uppercase()
		{
			IPasswordValidation validation = new PasswordValidation();
			var result = validation.Validate("1xxxxxxxxx");

			Assert.False(result.IsValid);
			Assert.AreEqual(result.Message, "Password must be at least 1 uppercase character.");
		}

		[Test]
		public void Valid_Password()
		{
			IPasswordValidation validation = new PasswordValidation();
			var result = validation.Validate("1Axxxxxxxx");

			Assert.True(result.IsValid);
			Assert.AreEqual(result.Message, "");
		}

	}
}
