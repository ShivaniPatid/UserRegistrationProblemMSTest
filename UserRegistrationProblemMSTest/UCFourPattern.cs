using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblemMSTest
{
    public class UCFourPattern
    {
        public string mobileNumber;

        public UCFourPattern(string mobileNumber)
        {
            this.mobileNumber = mobileNumber;
        }   

        public string ValideMobileNumber()
        {
            string pattern = "^[+][91]{2}[: :][6-9]{1}[0-9]{9}$";
            if(Regex.IsMatch(mobileNumber, pattern))
            {
                return mobileNumber;
            }
            else
            {
                return null;
            }
        }
    }
}
