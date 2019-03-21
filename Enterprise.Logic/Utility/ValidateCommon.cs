using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Enterprise.Logic.Utility
{
    public class ValidateCommon
    {
        public static bool IsValidEmail(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool IsValidState(string state)
        {
            if (state.Length > 2)
            {
                return false;
            }
            return true;
        }

        public static bool IsValidPostalCode(string postalCode)
        {
            if(string.IsNullOrEmpty(postalCode))
            {
                return false;
            }
            return true;
        }
    }
}
