using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    public class DateValidator
    {
        private readonly string userDate;

        public DateValidator(string userDate)
        {
            this.userDate = userDate;
        }

        // validate date based on the format (dd/mm/yyyy)
        public bool UserDateValidator()
        {
            bool valid = Regex.IsMatch(userDate, @"^([0-9]{2})\/([0-9]{2})\/([0-9]{4})$");
            return valid;
        }

        public string IsValid()
        {
            if (UserDateValidator())
            {
                return "Valid date";

            }
            return "Invalid date";
        }
    }
}
