using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWithUnitTest.ExtensionMethods
{
    public static class Extension
    {
        public static int ToSafeInt(this string valueToConvert, int defaultValue = 0)
        {
            bool canbeParsed = false;
            int result;
            canbeParsed = int.TryParse(valueToConvert, out result);
            if (!canbeParsed)
                result = defaultValue;
            return result;
        }
    }
}
