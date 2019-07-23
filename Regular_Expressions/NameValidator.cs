using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    public class NameValidator
    {
        public readonly string userName;

        public NameValidator(string userName)
        {
            this.userName = userName;
        }

        public bool UserNameValidator()
        {
            bool valid = Regex.IsMatch(userName, @"^([A-Z]{1})([a-z]{0,29})$");
            return valid;
        }

        public string IsValid()
        {
            if (UserNameValidator())
            {
                return "Valid name";
            }
            return "Invalid name";
        }
    }
}
