using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SureVersion.Util
{
    public class ValidationUtil
    {
        public static bool ToBoolean(object value)
        {
            try
            {
                string Value = value.ToString().Trim().ToLower();

                return Value == "true";
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
