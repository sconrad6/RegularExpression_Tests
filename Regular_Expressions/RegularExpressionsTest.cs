using System;

namespace Regular_Expressions
{
    class RegularExpressionsTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name");
            string userName = Console.ReadLine();

            Console.WriteLine("Please enter an email");
            string userEmail = Console.ReadLine();

            Console.WriteLine("Please enter a phone number");
            string userPhone = Console.ReadLine();

            Console.WriteLine("Please enter a date");
            string userDate = Console.ReadLine();

            Console.WriteLine("Please enter a website");
            string userWebsite = Console.ReadLine();

            NameValidator name1 = new NameValidator(userName);
            Console.WriteLine(name1.UserNameValidator());

            EmailValidator email1 = new EmailValidator(userEmail);
            Console.WriteLine(email1.AllValid());

            PhoneValidator phone1 = new PhoneValidator(userPhone);
            Console.WriteLine(phone1.PhoneNumberValidator());

            DateValidator date1 = new DateValidator(userDate);
            Console.WriteLine(date1.IsValid());

            WebsiteValidator website1 = new WebsiteValidator(userWebsite);
            Console.WriteLine(website1.IsValid());
        }

        //public static string UseRegex(string input, string regexInput)
        //{
        //    bool isValid = Regex.IsMatch(input, regexInput);
        //    if (isValid)
        //    {
        //        return "Valid";
        //    }
        //    return "Invalid";
        //}
    }
}
