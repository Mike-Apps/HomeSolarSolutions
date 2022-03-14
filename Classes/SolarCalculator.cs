using System;
using System.Collections.Generic;
using System.Text;

namespace HomeSolarSolutions
{
    class SolarCalculator
    {
       
        public string solarCalculate(String s)
        {
            int result;
            bool success = Int32.TryParse(s, out result);
            if (!success)
            {
                return  "Please enter only numbers";
            }
            result = result * 22;
            return result.ToString();
        }


    }
}
