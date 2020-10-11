using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.RequestResponseModel
{
    public class CvminfoModel
    {
        /*
         * Primary Account Number, length 1-40, fromat AN, Conditional
         */
        public string Pan { get; set; }
        
        /*
         * Account Number, length 1-40, fromat AN, Conditional
         */
        public string accountNo { get; set; }
        
        /*
         * Expiry Date, length 5, fromat ANS(MM/YY), Conditional
         */
        public string expiryDate { get; set; }

        /*
         * CVN2(Card verification number), length 3, fromat N, Conditional
         * Ex: ValidValues "IDcard", "Passport" 
         */
        public string cvn2 { get; set; }
        
        /*
         * FirstName, length 1-30, fromat S, Conditional
         */
        public string firstName { get; set; }
        
        /*
         *Middle Name, length 1-30, fromat S, Conditional
         */
        public string midName { get; set; }

        /*
         *Last Name, length 1-30, fromat S, Conditional
         */
        public string lastName { get; set; }

        /*
         * Mobile Number, length 1-25, fromat ANS, Conditional
         * Countrycode(1-3digits)+“-”+subscribernumber
         * If the country code is not present, UMPS will consider it as a Chinese mobilenumber.
         */
        public string mobileNo { get; set; }
        
        /*
         * ID Type, length 1-50, fromat AN, Conditional
         * Ex: ValidValues "IDcard", "Passport" 
         */
        public string idType { get; set; }

        /*
         * ID Number, length 1-25, fromat AN, Conditional
         */
        public string idNo { get; set; }

        /*
         * ID Country, length 1-3, fromat ANS, Conditional
         * Follow the “ISO 3166-1 numeric” standars.
         */
        public string idCountry { get; set; }
    }
}
