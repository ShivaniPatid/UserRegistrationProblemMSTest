using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblemMSTest
{
    public class UCTwoPattern
    {
        public string lastName;

        public UCTwoPattern(string lastName)
        {
            this.lastName = lastName;
        }

        public string ValidateLastName()
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            if(Regex.IsMatch(lastName, pattern))
            {
                return lastName;
            }
            else
            {
                return null;
            }
        }
    }
}
