using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    public class PhoneValidator
    {
       
        private readonly string userPhone;

        public PhoneValidator(string userPhone)
        {
            this.userPhone = userPhone;
        }

        // validate that the number is correctly formatted as: {area code of 3 digits} - {3 digits} - {4 digits}
        public string PhoneNumberValidator()
        {
        
             bool isValid = Regex.IsMatch(userPhone, @"^([0-9]{3}-[0-9]{3}-[0-9]{4})$");
             if (isValid)
            {
                return "Valid phone number";
            }
            return "Invalid phone number";
        }
    }
}

