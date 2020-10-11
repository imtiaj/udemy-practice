using System;
namespace DLL.Models
{
    //1.3.12 
    public class CardInfo
    {
        //Primary Account Number, length: 1-40, Format: AN, M/O/C: C,  Description:
        public string Pan { get; set; }

        //Masked, length: 1-40, Format: ANS, M/O/C: C,  Description:
        public string maskedPan { get; set; }

        //Card Face ID, length: 1-6, Format: AN, M/O/C: C,  Description:
        public string cardFaceID { get; set; }

        //Account Number, length: 1-40, Format: AN, M/O/C: C,  Description:
        public string accountNo { get; set; }

        //Expiry Date, length: 5, Format: ANS(MM/YY), M/O/C: C,  Description:
        public string expiryDate { get; set; }

        //CVN2, length: 3, Format: N, M/O/C: C,  Description:
        public int cvn2 { get; set; }

        //Card Product Code, length: 1-4, Format: AN, M/O/C: C,  Description:
        public string prdNo { get; set; }

        //Card Type, length: 1-50, Format: ANS, M/O/C: C,  Description:  Valid values:- Debit Card,  Credit Card, Prepay Card
        public string cardType { get; set; }

        //Card Medium, length: 1-50, Format: ANS, M/O/C: C,  Description:  Valid values:- CHIP,  CHIP_COMPOSITE,  VIRTUAL
        public string cardMed { get; set; }

        //Card State, length: 1-50, Format: ANS, M/O/C: C,  Description: Valid values:- ACTIVE, SUSPENDED, DELETED, LOST
        public string cardState { get; set; }
    }
}
