using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    public class EmailValidator
    {
        private readonly string userEmail;

        public EmailValidator(string userEmail)
        {
            this.userEmail = userEmail;
        }

       // method that checks to make sure the text before the domain is 5-30 characters in lengths
       // and contains alphanumerics 
        public bool DomainValidator()
        {
            bool valid = Regex.IsMatch(userEmail, @"^([a-z]{4,20})@([a-z]{5,10})+\.+([a-z]{1,3})$");
            return valid;
        }

        public string AllValid()
        {
            if (DomainValidator()) // && LengthValidator() && AlphanumericValidator())
            {
                return "Valid email";
            }
            return "Invalid email";
            }
        }
    }

