using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblemMSTest
{
    public class UCFivePattern
    {
        public string password;

        public UCFivePattern(string password)
        {
            this.password = password;
        }

        public string ValidatePassword()
        {
            var hasLowerChar = new Regex("^(?=.*[a-z]).{8,}$");
            if (!hasLowerChar.IsMatch(password))
            {
                Console.WriteLine("password should have minimum 8 characters");
                return null;
            }
            else
            {
                //Console.WriteLine("Password is valid");
                return password;
            }
        }
    }
}
