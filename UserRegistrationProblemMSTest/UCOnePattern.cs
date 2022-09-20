using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblemMSTest
{
    public class UCOnePattern
    {
        public string firstName;

        public UCOnePattern(string firstName)
        {
            this.firstName = firstName;
        }
    
        public string ValidateFirstName()
        {

            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(firstName, pattern))
            {
                return firstName;
            }
            else
            {
                return firstName;
            }
        }
    }
}
