using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNUltimate.UserLogin
{
    public class Validate_
    {

        public static ValidateResponse ValidatePasswordStrength(string pwd)
        {
            if (pwd.Length < 6)
            {
                return new ValidateResponse(false, "Password is shorter than 6 characters.\nMake your password between length 6 - 16");
            }

            if (pwd.Length > 16)
            {
                return new ValidateResponse(false, "Password is greater than 16 characters.\nMake your password between length 6 - 16");
            }

            if (!pwd.Any(char.IsLower))
            {
                return new ValidateResponse(false, "Password should have 1 lower case character.");
            }

            if (!pwd.Any(char.IsUpper))
            {
                return new ValidateResponse(false, "Password should have 1 upper case character.");
            }

            if (pwd.Contains(" "))
            {
                return new ValidateResponse(false, "Password can\'t have whitespace.");
            }

            char[] specialChars = @"~!@#$%^&*()<>?:{}_+-=,./;\'".ToCharArray();
            string specialCharsStr = @"~!@#$%^&*()<>?:{}_+-=,./;\'";
            bool ok = false;

            foreach (char c in specialChars)
            {
                if (pwd.Contains(c))
                {
                    ok = true;
                    break;
                }
            }

            if (!ok)
            {
                return new ValidateResponse(false, "Password must contain a special character.\nThe special characters you can use are:\n" + specialCharsStr);
            }

            char[] numbers = "1234567890".ToArray();
            string numbersStr = "1234567890";
            bool okn = false;

            foreach (char c in numbers)
            {
                if (pwd.Contains(c))
                {
                    okn = true;
                }
            }

            if (!okn)
            {
                return new ValidateResponse(false, "Password must contain a number.");
            }

            return new ValidateResponse(true, "");
        }

    }


}
