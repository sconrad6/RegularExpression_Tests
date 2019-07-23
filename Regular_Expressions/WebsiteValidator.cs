using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    public class WebsiteValidator
    {
        private readonly string userWebsite;

        public WebsiteValidator(string userWebsite)
        {
            this.userWebsite = userWebsite;
        }

        // method that validates HTML elements
        public bool UserHTMLValidator()
        {
            bool valid = Regex.IsMatch(userWebsite, @"^\<\/?[\w]+\>$");
            return valid;
        }

        public string IsValid()
        {
            if (UserHTMLValidator())
            {
                return "Valid website";
            }
            return "Invalid website";
        }
    }
}
