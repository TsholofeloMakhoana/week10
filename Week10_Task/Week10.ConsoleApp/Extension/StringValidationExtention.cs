
using System.Text.RegularExpressions;

namespace Week10.ConsoleApp
{
    public static class StringValidationExtention
    {
        public static bool ValidateEmail(string emailAddress)
        {
            string email = emailAddress;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
